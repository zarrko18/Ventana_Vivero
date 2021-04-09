using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WebApplication7.Model;
namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        DaoVivero dao = new DaoVivero();

        [HttpGet]
        [Route("Lista")]
        public object Datos()
        {

            List<Vivero> viv = dao.Listar_Vivero();

            var obj = JsonConvert.SerializeObject(viv);

            return obj;


        }

        [HttpPost]   
        [Route("Vivero")]
        public String Vivero(Vivero viv)
        {
            string result = "Problem";
          
           
            int res =  dao.Agregar_Viviero(viv);

            if (res == 1) {
                result = "Exito";
            }
            

            return result;
        }
    }
}
