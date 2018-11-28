using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class PublishingController : Controller
    {
        List<Publishing> list;
        List<Country> countries;

        private void Init()
        {
            countries = new List<Country>();

            Country belarus = new Country();
            belarus.Name = "Беларусь";
            belarus.Id = 1;
            City c11 = new City();
            c11.Id = 1;
            c11.Name = "Могилев";
            City c12 = new City();
            c11.Id = 2;
            c11.Name = "Минск";
            City c13 = new City();
            c11.Id = 3;
            c11.Name = "Брест";
            City c14 = new City();
            c11.Id = 4;
            c11.Name = "Гомель";
            City c15 = new City();
            c11.Id = 5;
            c11.Name = "Витебск";
            belarus.Cities = new List<City>();
            belarus.Cities.Add(c11);
            belarus.Cities.Add(c12);
            belarus.Cities.Add(c13);
            belarus.Cities.Add(c14);
            belarus.Cities.Add(c15);
            countries.Add(belarus);

            Country russia = new Country();
            russia.Name = "Россия";
            russia.Id = 2;
            City c21 = new City();
            c11.Id = 1;
            c11.Name = "Москва";
            City c22 = new City();
            c11.Id = 2;
            c11.Name = "Питер";
            City c23 = new City();
            c11.Id = 3;
            c11.Name = "Крым";
            City c24 = new City();
            c11.Id = 4;
            c11.Name = "Волга";
            City c25 = new City();
            c11.Id = 5;
            c11.Name = "Манильск";
            russia.Cities = new List<City>();
            russia.Cities.Add(c21);
            russia.Cities.Add(c22);
            russia.Cities.Add(c23);
            russia.Cities.Add(c24);
            russia.Cities.Add(c25);
            countries.Add(russia);


            Publishing p1 = new Publishing()
            {
                Id = 1,
                Name = "Pixart",
                Address = new Address()
                {
                    Country = countries[0],
                    City = countries[0].Cities[1],
                    Street = "Пионерская",
                    Home = "24"
                }
            };
            Publishing p2 = new Publishing()
            {
                Id = 2,
                Name = "Новости могилев",
                Address = new Address()
                {
                    Country = countries[0],
                    City = countries[0].Cities[3],
                    Street = "Криулина",
                    Home = "11"
                }
            };

            Publishing p3 = new Publishing()
            {
                Id = 3,
                Name = "СБ Беларусь",
                Address = new Address()
                {
                    Country = countries[1],
                    City = countries[1].Cities[3],
                    Street = "Новосёлки",
                }
            };

            Publishing p4 = new Publishing()
            {
                Id = 4,
                Name = "Вести",
                Address = new Address()
                {
                    Country = countries[0],
                    City = countries[0].Cities[2],
                    Street = "Падольск",
                    Home = "12"
                }
            };

            list = new List<Publishing>() { p1, p2, p3, p4 };
        }

        [HttpGet]
        public ActionResult All()
        {

            Init();
            return View(Mapper.Map<Publishing, PublishingModel>(list));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreatePublishingModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Init();
            return View(Mapper.Map<Publishing, EditPublishingModel>(list.FirstOrDefault(x => x.Id == id)));
        }

        [HttpPost]
        public ActionResult Edit(EditPublishingModel model)
        {
            return View();
        }

        [HttpPost]
        public void Delete(int id)
        {
            RedirectToAction("All");
        }
    }
}