using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTestCore.Models
{
    public class Shoes
    {
        public string ImageSource { get; set; }
        public string ShoeName { get; set; }
        public string SubTitle { get; set; }
        public string Distance { get; set; }
        public bool IsFavourite { get; set; }
        public string FavouriteSource
        {
            get
            {
                if (IsFavourite)
                    return "ic_launcher.png";
                else
                    return "ic_launcher.png";
            }
        }
    }
}
