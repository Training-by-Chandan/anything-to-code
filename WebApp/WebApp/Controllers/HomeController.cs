using AutoMapper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGithubRepository githubRepository;
        private readonly IMapper mapper;

        public HomeController(
            IGithubRepository githubRepository,
            IMapper mapper
            )
        {
            this.githubRepository = githubRepository;
            this.mapper = mapper;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View("Contact");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GithubPost()
        {
            var stream = Request.InputStream;
            var buffer = new byte[stream.Length];
            var bytes = stream.Read(buffer, 0, buffer.Count());
            var str = System.Text.Encoding.ASCII.GetString(buffer);
            var githubModel = new GithubModel()
            {
                Payloads = str
            };
            githubRepository.Create(githubModel);
            var gh = new GithubViewModel() { Payloads = str };
            SendMessageToViber("New Commit => " + gh.PayloadObj.head_commit.message);
            Response.StatusCode = 200;
            return null;
        }

        [HttpGet]
        public ActionResult Github()
        {
            var data = githubRepository.GetAll().ToList();
            var result = mapper.Map<List<GithubModel>, List<GithubViewModel>>(data);

            return View(result);
        }

        private void SendMessageToViber(string Message)
        {
            var client = new RestClient("https://chatapi.viber.com/pa/send_message");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-Viber-Auth-Token", "<Token here>");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{""receiver"": ""<id>"",""min_api_version"": 1,""sender"": {""name"": ""Chandan Gupta Bhagat"",""avatar"": ""https://media-direct.cdn.viber.com/download_photo?dlid=DyuDjdjdZ-USMi1NHM04V-o9wvsxLIpVnuI4dfkKN6dlMQW2-55xE2Umw85g116iHKCwBbcTF-EGiNJ7MTGHjrh4zenIv9f9Nr4KrgHOFN_QvgExFkMzZaeK4ka4xnRCLb3oaA&fltp=jpg&imsz=0000""},""tracking_data"": ""Some data"",""type"": ""text"",""text"": ""I am Chandan""}";
            var viberModel = JsonConvert.DeserializeObject<ViberModel>(body);
            viberModel.text = Message;
            request.AddParameter("application/json", JsonConvert.SerializeObject(viberModel, Formatting.Indented), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}