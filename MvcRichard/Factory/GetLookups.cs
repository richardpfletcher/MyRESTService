
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Linq;
using System;
using System.Configuration;
using MvcRichard.Models;


namespace MvcRichard.Factory
{
    public class GetLookups
    {

        //NameValueCollection myKeys = ConfigurationManager.AppSettings;
        


        
       

        public DropdownModel GetCategory()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var env = ConfigurationManager.AppSettings["Enviroment"];
                var settings = "";
                var uri = new Uri("https://api.evolutionrevolutionoflove.com/api/category");


                if (env == "Dev")
                {
                    settings = ConfigurationManager.AppSettings["LocalWebApi"];
                    uri = new Uri("http://localhost:18760/api/category/");

                }
                else
                {
                    settings = ConfigurationManager.AppSettings["ProductionWebApi"];
                    uri = new Uri("https://api.evolutionrevolutionoflove.com/api/category");


                }




                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("categoryLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("Category").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GetTheme()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var env = ConfigurationManager.AppSettings["Enviroment"];
                var settings = "";
                var uri = new Uri("https://api.evolutionrevolutionoflove.com/api/theme");


                if (env == "Dev")
                {
                    settings = ConfigurationManager.AppSettings["LocalWebApi"];
                    uri = new Uri("http://localhost:18760/api/theme/");

                }
                else
                {
                    settings = ConfigurationManager.AppSettings["ProductionWebApi"];
                    uri = new Uri("https://api.evolutionrevolutionoflove.com/api/theme");


                }




                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("categoryLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("Category").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }




    }
}