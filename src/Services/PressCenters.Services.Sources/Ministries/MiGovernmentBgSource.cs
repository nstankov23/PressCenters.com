﻿namespace PressCenters.Services.Sources.Ministries
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using AngleSharp.Dom;

    using PressCenters.Common;

    /// <summary>
    /// Министерство на икономиката.
    /// </summary>
    public class MiGovernmentBgSource : BaseSource
    {
        public override string BaseUrl { get; } = "https://www.mi.government.bg/";

        public override IEnumerable<RemoteNews> GetLatestPublications() =>
            this.GetPublications("bg/news.html", ".col2 .row a.bold", "bg/news");

        public override IEnumerable<RemoteNews> GetAllPublications()
        {
            for (var i = 1895; i <= 3635; i++)
            {
                var remoteNews = this.GetPublication($"{this.BaseUrl}bg/news/news-{i}.html");
                if (remoteNews == null)
                {
                    continue;
                }

                Console.WriteLine($"News {i} => {remoteNews.Title}");
                yield return remoteNews;
            }
        }

        public override string ExtractIdFromUrl(string url) => url.GetLastStringBetween("-", ".html", url);

        protected override RemoteNews ParseDocument(IDocument document)
        {
            var titleElement = document.QuerySelector(".col2 .title-1");
            if (titleElement == null)
            {
                return null;
            }

            var title = titleElement?.TextContent;

            var timeElement = document.QuerySelector(".col2 .text-gray-1");
            var timeAsString = timeElement?.TextContent?.Trim();
            var time = DateTime.ParseExact(timeAsString, "dd MMMM yyyy", CultureInfo.GetCultureInfo("bg-BG"));

            var imageElement = document.QuerySelector(".col2 div.left img");
            var imageUrl = imageElement?.GetAttribute("src") ?? "/images/sources/mi.government.bg.png";

            var contentElement = document.QuerySelector(".col2");
            this.RemoveRecursively(contentElement, titleElement);
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 .separator-1"));
            this.RemoveRecursively(contentElement, timeElement);
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 div.left")); // images
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 .link-print"));
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 .butt-1"));
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 .clear2"));
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 .clear3"));
            this.RemoveRecursively(contentElement, document.QuerySelector(".col2 #comments"));
            this.NormalizeUrlsRecursively(contentElement, this.BaseUrl);
            var content = contentElement?.InnerHtml;

            return new RemoteNews(title, content, time, imageUrl);
        }
    }
}