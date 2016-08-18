using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PairingTest.Web.Models;
using RestSharp;
using System.Configuration;

namespace PairingTest.Web.Helper
{
    public class ServerDataRestClient : IServerDataRestClient
    {
        private readonly string uri = ConfigurationManager.AppSettings["QuestionnaireServiceUri"];
        private readonly RestClient client;

        public ServerDataRestClient()
        {
            client = new RestClient(uri);
        }
        public void Add(QuestionnaireViewModel questionnaireViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public QuestionnaireViewModel GetAll()
        {
            var request = new RestRequest("api/questions", Method.GET) { RequestFormat = DataFormat.Json };

            var response = client.Execute<QuestionnaireViewModel>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public QuestionnaireViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(QuestionnaireViewModel questionnaireViewModel)
        {
            throw new NotImplementedException();
        }
    }
}