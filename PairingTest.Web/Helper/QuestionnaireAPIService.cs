using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PairingTest.Web.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Configuration;

namespace PairingTest.Web.Helper
{

    public class QuestionnaireAPIService : IServerDataRestClient
    {
        public static readonly string uri = ConfigurationManager.AppSettings["QuestionnaireServiceUri"];


        public async Task<QuestionnaireViewModel> GetAll()
        {
            //  IList<QuestionnaireViewModel> questionnaireList = new List<QuestionnaireViewModel>();
            QuestionnaireViewModel obj = new QuestionnaireViewModel();
            string url = "http://localhost:1011/api/questions";
            using (HttpClient httpClient = new HttpClient())
            {

                dynamic data = JsonConvert.DeserializeObject(await httpClient.GetStringAsync(!string.IsNullOrEmpty(uri) ? uri : url), typeof(object));
                // dynamic data = JValue.Parse();
                obj.QuestionnaireTitle = data.QuestionnaireTitle;
                List<string> quesText = new List<string>();

                foreach (var ques in data.QuestionsText)
                {
                    quesText.Add(ques.ToString());

                }

                obj.QuestionsText = quesText;
                return obj;
            }
        }

        public void Add(QuestionnaireViewModel questionnaireViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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