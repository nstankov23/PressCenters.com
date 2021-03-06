﻿namespace PressCenters.Web.Components
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using PressCenters.Data.Common.Repositories;
    using PressCenters.Data.Models;
    using PressCenters.Services.Mapping;
    using PressCenters.Web.ViewModels.MainNews;

    [ViewComponent(Name = "MainNews")]
    public class MainNewsViewComponent : ViewComponent
    {
        private readonly IDeletableEntityRepository<MainNews> mainNewsRepository;

        public MainNewsViewComponent(IDeletableEntityRepository<MainNews> mainNewsRepository)
        {
            this.mainNewsRepository = mainNewsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var news = this.mainNewsRepository.All().Where(x => !x.Source.IsDeleted).GroupBy(
                    x => x.SourceId,
                    (key, g) => g.OrderByDescending(e => e.Id).FirstOrDefault()).OrderByDescending(x => x.CreatedOn)
                .To<MainNewsViewModel>().ToList();
            var viewModel = new MainNewsComponentViewModel { MainNews = news };
            return this.View(viewModel);
        }
    }
}
