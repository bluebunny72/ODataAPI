using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using ODataAPI.Console.Models;

namespace ODataAPI.Console
{
    public class ODataHelper : IDisposable
    {
        private RestClient _client;

        public ODataHelper()
        {
           
            string apiURL = "http://odata.ilcdover.com/syteline/";          

            _client = new RestClient(apiURL);       
            _client.Authenticator = new NtlmAuthenticator();
        }

        public JobOrderModel GetJobOrderByJob(string job)
        {
            //https://docs.microsoft.com/en-us/odata/concepts/queryoptions-overview
            string apiEndpoint = $"api/JETS/JobOrders?$filter=Job eq '{job}'";

            RestRequest request = new RestRequest(apiEndpoint, DataFormat.Json);
            IRestResponse response = _client.Get(request);
            JobOrderModel model = JsonConvert.DeserializeObject<JobOrderModel>(response.Content.ToString());

            return model;
        }

        public void Dispose()
        {
            this._client = null;
        }
    }
}
