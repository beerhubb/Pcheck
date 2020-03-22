using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using ProjectCheck.Models;

namespace ProjectCheck.Controllers
{
    public class HomeController : Controller
    {
        private IMongoCollection<insertdata> insertCollection;
        private IMongoCollection<AddAu> AuCollection;
        public HomeController()
        {
            var dbcilent = new MongoClient("mongodb://LexAdmin:lexza007@cluster0-shard-00-00-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-01-pqdfa.azure.mongodb.net:27017,cluster0-shard-00-02-pqdfa.azure.mongodb.net:27017/test?replicaSet=Cluster0-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("LexDataBase");
            insertCollection = database.GetCollection<insertdata>("Insert");
            AuCollection = database.GetCollection<AddAu>("insertAu");
        }

        public IActionResult Index()
        {
            var item = insertCollection.Find(it => true).ToList();

            return View(item);
        }

        public IActionResult detail(string id)
        {
            var item = insertCollection.Find(it => it._id == id).FirstOrDefault();

            return View(item);
        }

        public IActionResult price()
        {
            var item = insertCollection.Find(it => it.status == "1").ToList();

            return View(item);
        }

        public IActionResult address()
        {
            var item = AuCollection.Find(it => true).ToList();

            return View(item);
        }

        public IActionResult det(string id)
        {
            var item = AuCollection.Find(it => it._id == id).FirstOrDefault();

            return View(item);
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(Login check)
        {
            var user = (check.id == "admin" && check.pass == "123456");
            if (user == true)
            {
                return RedirectToAction("ift");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ift()
        {

            return View();
        }

        public IActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult insert(insertdata data)
        {
            var item = new insertdata
            {

                _id = Guid.NewGuid().ToString(),
                pictrue = data.pictrue,
                name = data.name,
                price = data.price,
                detail = data.detail,
                status = data.status
            };
            insertCollection.InsertOne(item);
            return RedirectToAction("insert");
        }

        public IActionResult insertAu()
        {

            return View();
        }

        [HttpPost]
        public IActionResult insertAu(AddAu data)
        {
            var item = new AddAu
            {
                _id = Guid.NewGuid().ToString(),
                name = data.name,
                address = data.address,
                phon = data.phon
            };
            AuCollection.InsertOne(item);
            return RedirectToAction("insertAu");
        }
    }
}
