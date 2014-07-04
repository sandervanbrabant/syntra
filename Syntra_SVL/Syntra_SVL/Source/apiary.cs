using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Syntra_SVL.Source
{
    class apiary
    {
        private readonly string sURL_Apiary = "http://private-825b3-svl.apiary-mock.com/api/";
        private readonly string sJSON = "application/json";

        public apiary()
        {
        }

        public string requestApiary(string[] sData)
        {
            try
            {
                return requestFromApiary(sData[0], sData[1], sData[2]);
            }
            catch (Exception ex)
            {
                return "error\n\n" + ex.Message;
            }
        }

        private string requestFromApiary(string sData, string sPath, string sMethod)
        {
            var request = System.Net.WebRequest.Create(sURL_Apiary + sPath) as System.Net.HttpWebRequest;
            request.KeepAlive = true;
            request.Method = sMethod;
            request.ContentType = sJSON;
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(sData);
            request.ContentLength = byteArray.Length;
            using (var writer = request.GetRequestStream()) { writer.Write(byteArray, 0, byteArray.Length); }

            string responseContent = null;
            using (var response = request.GetResponse() as System.Net.HttpWebResponse)
            {
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseContent = reader.ReadToEnd();
                }
            }
            return responseContent;
        }
    }
}