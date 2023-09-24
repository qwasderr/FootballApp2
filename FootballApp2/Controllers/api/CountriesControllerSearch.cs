
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;
using MimeKit.Cryptography;
using System.Diagnostics;
using Microsoft.Azure.Search;
using Nest;
using Microsoft.Azure.Search.Models;

namespace FootballApp2.Controllers.api
{
    [Route("/search")]
    public class CountriesControllerSearch:Controller
    {
        [HttpGet("{search}")]
        public ActionResult Index(string search) {
            var SSN = "footballappsearch";
            var API = "3R1Wdaa4MJOuS21suaH5A7KHgT84NuvjIdxuLdq6FiAzSeARtYDT";
            var searchClient = new SearchServiceClient(SSN, new SearchCredentials(API));
            var indexClient = searchClient.Indexes.GetClient("azuresql-index");
            SearchParameters searchparam = new SearchParameters() { SearchMode = SearchMode.All };
            var docs = indexClient.Documents.Search(search, searchparam);
            return Json(docs.Results, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}
