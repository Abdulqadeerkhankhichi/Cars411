using Cars411.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cars411.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Details()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("Comfart", 1));
            dataPoints.Add(new DataPoint("Safety", 2));
            dataPoints.Add(new DataPoint("Reliability", 4));
          

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            return View();
        }

        public ActionResult AllCarList()
        {
            return View();
        }

    }
}