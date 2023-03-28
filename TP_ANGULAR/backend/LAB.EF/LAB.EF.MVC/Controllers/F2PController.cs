using LAB.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace LAB.EF.MVC.Controllers
{
    public class F2PController : Controller
    {
        // GET: Cocktail
        public async Task<ActionResult> Index()
        {
            List<F2PViewModel> lf2p = await GetRandomCocktail();
            return View(lf2p);
        }

        public async Task<List<F2PViewModel>> GetRandomCocktail()
        {
            
            HttpClient httpClient = new HttpClient();

            List<F2PViewModel> lf2p = null;
            HttpResponseMessage ms = await httpClient.GetAsync("https://www.freetogame.com/api/games");
            if (ms.IsSuccessStatusCode)
            {

                var resultado = await ms.Content.ReadAsStringAsync();

                lf2p = JsonConvert.DeserializeObject<List<F2PViewModel>>(resultado);
            }
            return lf2p;

        }
    }
}