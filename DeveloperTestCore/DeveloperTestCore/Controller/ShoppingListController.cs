using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperTestCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTestCore.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        List<Shoes> CartItems = new List<Shoes>();
        public ShoppingListController()
        {
            //Dummy data's for checking purpose
            CartItems.Add(new Shoes
            {
                ImageSource = "bow_elegant.jpg",
                ShoeName = "Princes Shoes",
                SubTitle = "Perfect",
                Distance = "5 KM",
                IsFavourite = false
            });
            CartItems.Add(new Shoes
            {
                ImageSource = "fashion_footwear_shoes.jpg",
                ShoeName = "Nice Sneakers",
                SubTitle = "Light Used",
                Distance = "1 KM",
                IsFavourite = true
            });
            CartItems.Add(new Shoes
            {
                ImageSource = "footwear_shoe.jpg",
                ShoeName = "Shoe With Light",
                SubTitle = "New",
                Distance = "5 KM",
                IsFavourite = false
            });
            CartItems.Add(new Shoes
            {
                ImageSource = "fashion_high.jpg",
                ShoeName = "Classic Vans",
                SubTitle = "Used",
                Distance = "3 KM",
                IsFavourite = true
            });
            CartItems.Add(new Shoes
            {
                ImageSource = "blue_casual.jpg",
                ShoeName = "Ballarine Shoe",
                SubTitle = "Used",
                Distance = "4 KM",
                IsFavourite = false
            });
            CartItems.Add(new Shoes
            {
                ImageSource = "fashion_footwear.jpg",
                ShoeName = "Black Sneakers",
                SubTitle = "Heavy Used",
                Distance = "2.5 KM",
                IsFavourite = false
            });
        }
        [HttpGet]
        //http://Yourhost/api/ShoppingList/hello
        public string Hello()
        {
            return "Hello \nThis is for demo";
        }        
        [HttpGet]
        //http://Yourhost/api/ShoppingList/GetShoes
        public IEnumerable<Shoes> GetShoes()
        {
            return CartItems;
        }
        [HttpGet]
        //http://Yourhost/api/ShoppingList/GetShoes?id=1
        public Shoes GetShoe(int id)
        {
            return CartItems[id];
        }
        [HttpPost]
        ////http://Yourhost/api/ShoppingList/GetShoes
        public Shoes PostShoe([FromBody]Shoes shoe)
        {
            return shoe;
        }
    }
}