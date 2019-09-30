using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
       
        string caminhoApi = "http://localhost:51111/api/Usuario";
        MultipartFormDataContent content = new MultipartFormDataContent();

        public async Task<IActionResult> Index()
        {
            List<Usuario> usuariosList = new List<Usuario>();
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                using (var response = await httpClient.GetAsync(caminhoApi))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    usuariosList = JsonConvert.DeserializeObject<List<Usuario>>(apiResponse);
                }
            }
            return View(usuariosList);
        }



        public ViewResult GetUsuarios() => View();

        [HttpPost]
        public async Task<IActionResult> GetUsuarios(int id)
        {
            Usuario usuarios = new Usuario();
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                using (var response = await httpClient.GetAsync(caminhoApi + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    usuarios = JsonConvert.DeserializeObject<Usuario>(apiResponse);
                }
            }
            return View(usuarios);
        }

        [HttpGet]
        public ViewResult AddUsuarios()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuarios(Usuario usuarios)
        {           
            if (!ModelState.IsValid)
            {
                
                return View(usuarios);
            }

            Usuario receivedUsuarios = new Usuario();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(usuarios), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(caminhoApi, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedUsuarios = JsonConvert.DeserializeObject<Usuario>(apiResponse);
                }
            }
            ViewData["Mensagem"] = "Sucesso";
            return View(receivedUsuarios);
        }




        public async Task<IActionResult> UpdateUsuarios(int id)
        {
           
            Usuario usuarios = new Usuario();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(caminhoApi + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    usuarios = JsonConvert.DeserializeObject<Usuario>(apiResponse);
                }
            }
            return View(usuarios);
        }
        


        
        [HttpPost]
        public async Task<IActionResult> UpdateUsuarios(Usuario usuarios)
        {
            if (!ModelState.IsValid)
            {
                return View(usuarios);
            }
            Usuario receivedUsuarios = new Usuario();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(usuarios), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(caminhoApi, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedUsuarios = JsonConvert.DeserializeObject<Usuario>(apiResponse);
                }
            }

           
            return View(receivedUsuarios);
        }
      
		[HttpPost]
		public async Task<IActionResult> DeleteUsuarios(int id)
		{
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.DeleteAsync(caminhoApi + "/" + id))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
				}
			}
		 
			return RedirectToAction("Index");
		}



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
