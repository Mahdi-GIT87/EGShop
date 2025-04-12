using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Interfaces
{
    public interface IQuestion
    {
        bool CreateQuestion(Question question);
        bool UpdateQuestion(Question question);
        bool DeleteQuestion(int id);
        IEnumerable<Question> GetAllQuestions();
        Question GetQuestionById(int id);
    }
}
