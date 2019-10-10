using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        /*
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        */
        //cambiando el metodo index con el actionResult
        public ActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        /*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        // recibiendo datos por la url esto es tipo metodo get
        /* public string Welcome(string name, int numTimes = 1)//parametro opcional
         {
             return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
         }
         */
        // mismo metodo get pero con ID recibo parametros por url tipo get
        /*public string Welcome(string name, int ID = 1)
        {// De esta manera la plantilla de vista interactua con la capa de negocio nunca 
            //debe realizar una lógica empresarial o interactuar 
            //con una base de datos directamente
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }*/
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}