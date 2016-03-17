using System.Collections.Generic;
using GlassMapperWalkthrough.Domain.Models.Sitecore_Templates.Glass_Mapper_Walkthrough.Shared_Content.Items;

namespace GlassMapperWalkthrough.Web.Models
{
    public class CarouselViewModel
    {
        public bool DisplayPreviousAndNextButtons { get; set; }
        public List<ICarousel_Slide> CarouselSlides { get; set; }

        public CarouselViewModel()
        {
            CarouselSlides = new List<ICarousel_Slide>();
        }
    }
}