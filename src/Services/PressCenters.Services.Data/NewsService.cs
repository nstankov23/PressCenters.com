﻿namespace PressCenters.Services.Data
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using AngleSharp.Parser.Html;

    using PressCenters.Data.Common.Repositories;
    using PressCenters.Data.Models;

    public class NewsService : INewsService
    {
        private readonly IDeletableEntityRepository<News> newsRepository;

        public NewsService(IDeletableEntityRepository<News> newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        public async Task<bool> AddAsync(RemoteNews remoteNews, int sourceId)
        {
            if (this.newsRepository.AllWithDeleted()
                .Any(x => x.SourceId == sourceId && x.RemoteId == remoteNews.RemoteId))
            {
                // Already exists
                return false;
            }

            var news = new News
                         {
                             Title = remoteNews.Title?.Trim(),
                             OriginalUrl = remoteNews.OriginalUrl?.Trim(),
                             ImageUrl = remoteNews.ImageUrl?.Trim(),
                             Content = remoteNews.Content?.Trim(),
                             CreatedOn = remoteNews.PostDate,
                             SourceId = sourceId,
                             RemoteId = remoteNews.RemoteId?.Trim(),
                         };
            news.SearchText = this.GetSearchText(news);

            await this.newsRepository.AddAsync(news);
            await this.newsRepository.SaveChangesAsync();
            return true;
        }

        public async Task UpdateAsync(int id, RemoteNews remoteNews)
        {
            var news = this.newsRepository.AllWithDeleted().FirstOrDefault(x => x.Id == id);
            if (news == null)
            {
                return;
            }

            if (remoteNews == null)
            {
                return;
            }

            news.Title = remoteNews.Title;
            news.OriginalUrl = remoteNews.OriginalUrl;
            news.ImageUrl = remoteNews.ImageUrl;
            news.Content = remoteNews.Content;
            news.RemoteId = remoteNews.RemoteId;
            news.SearchText = this.GetSearchText(news);
            //// We should not update the PostDate here

            await this.newsRepository.SaveChangesAsync();
        }

        public int Count()
        {
            return this.newsRepository.All().Count();
        }

        public string GetSearchText(News news)
        {
            // Get only text from content
            var parser = new HtmlParser();
            var document = parser.Parse($"<html><body>{news.Content}</body></html>");

            // Append title
            var text = news.Title + " " + document.Body.TextContent;

            // Split by whitespace characters and remove duplicate values as well as non-alphanumeric characters
            var regex = new Regex(@"[^\w\d ]", RegexOptions.Compiled);
            var words = text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => regex.Replace(x, string.Empty)).Where(x => x.Length > 1).Distinct();

            // Combine all words
            return string.Join(" ", words);
        }
    }
}
