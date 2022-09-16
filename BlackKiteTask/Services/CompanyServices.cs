using System;
using System.Collections.Generic;
using System.Text;
using BlackKiteTask.Models;
using Newtonsoft.Json;

namespace BlackKiteTask
{
    static class CompanyServices
    {
        static string jsonData = "";
        static public Token SetToken
        {
            set
            {
                WebApiServices.SetToken = value;
            }
        }
        static public List<Companies> GetCompanies()
        {
            jsonData = WebApiServices.GetAll().Result;
            return JsonConvert.DeserializeObject<List<Companies>>(jsonData);
        }

        static public List<Companies> GetOneCompany(int id)
        {
            jsonData = WebApiServices.GetOne(id).Result;
            return JsonConvert.DeserializeObject<List<Companies>>(jsonData);
        }
        static public List<Companies> GetSummary(int id)
        {
            jsonData = WebApiServices.GetSummary(id).Result;
            return JsonConvert.DeserializeObject<List<Companies>>(jsonData);
        }
        static public string PostCompany(NewCompany company)
        {
            jsonData = WebApiServices.Post<NewCompany>(company).Result;
            return JsonConvert.DeserializeObject(jsonData).ToString();
        }
        static public string SeacrhCompany(Companies company)
        {
            jsonData = WebApiServices.Search<Companies>(company).Result;
            return JsonConvert.DeserializeObject(jsonData).ToString();
        }
        static public string Delete(int id)
        {
            jsonData = WebApiServices.Delete(id).Result;
            return JsonConvert.DeserializeObject(jsonData).ToString();
        }
    }
}
