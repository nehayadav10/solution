using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairingTest.Web.Helper
{
    public interface IServerDataRestClient
    {
        void Add(QuestionnaireViewModel questionnaireViewModel);
        void Delete(int id);
        Task<QuestionnaireViewModel> GetAll();

        //  QuestionnaireViewModel GetAll();
        QuestionnaireViewModel GetById(int id);

        void Update(QuestionnaireViewModel questionnaireViewModel);
    }
}
