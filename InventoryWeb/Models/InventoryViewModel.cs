using Common.Util;
using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InventoryWeb.Models
{
    public class InventoryViewModel
    {
        public List<ItemInventory> InventoryItems { get; set; }

        public List<ItemDetails> Details { get; set; }
        public List<ItemInventory> GetItemInventory()
        {
            List<ItemInventory> result = new List<ItemInventory>();
            result = JsonHelper.ConvertJsonToGenericObject<List<ItemInventory>>(GetApi("https://localhost:44348/Item", "GET"));
            return result;
        }


        public List<ItemDetails> GetDeatilbyItemId(int id)
        {
            List<ItemDetails> result = new List<ItemDetails>();
            result.Add(JsonHelper.ConvertJsonToGenericObject<ItemDetails>(GetApi(string.Format("https://localhost:44348/Item/{0}", id), "GET")));
            return result;
        }

        private string GetApi(string url, string metodo)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = metodo;
            request.ContentType = "application/x-www-form-urlencoded"; //"application/json; charset=utf-8";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }
    }
}
