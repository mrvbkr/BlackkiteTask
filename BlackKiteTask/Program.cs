using BlackKiteTask.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlackKiteTask
{
    class Program
    {
        //private static string APIUrl = "https://seam.riskscore.cards//api/";
        private static string clientID = "";
        private static string clientSecret = "";
        private static string company = "";

        static void Main(string[] args)
        {
           
            Console.Write("Client ID : ");
            clientID = Console.ReadLine();
            Console.Write("Client Secret : ");
            clientSecret= Console.ReadLine();
            Console.Write("Company: ");
            company = Console.ReadLine();

            string jsonToken = WebApiServices.GetToken(clientID,clientSecret).Result;
            Token token = JsonConvert.DeserializeObject<Token>(jsonToken);
            CompanyServices.SetToken = token;

            //Ekosistemlerin listesi
            string ecosystems = WebApiServices.GetEcosystems().Result;

            //İzlenen şirketlerin listesi
            CompanyServices.GetCompanies().ToList().ForEach(c => Console.WriteLine($"{c.CompanyId} {c.CompanyName}"));
            
           //Yeni şirket ekleme
           string newCompany= CompanyServices.PostCompany(new NewCompany
            {
                MainDomainValue = company,
                EcosystemId =5281,
            });
            PostCompanyResponse res = JsonConvert.DeserializeObject<PostCompanyResponse>(newCompany);

            //Tarama
            string summary = WebApiServices.GetSummary(res.CompanyId).Result;
            Console.WriteLine(summary);
            Console.Read();
        }
        
       
    }

}
