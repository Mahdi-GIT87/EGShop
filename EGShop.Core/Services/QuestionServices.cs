using EGShop.Core.Interfaces;
using EGShop.Datalayer.Context;
using EGShop.Datalayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Core.Services
{
    public class QuestionServices : IQuestion
    {
        private readonly EGShopContext _Context;
        public QuestionServices(EGShopContext context)
        {
            _Context = context;
        }

        public bool CreateQuestion(Question question)
        {
            try
            {
                _Context.Questions.Add(question);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteQuestion(int id)
        {
            try
            {
                _Context.Questions.Remove(GetQuestionById(id));
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _Context.Questions;
        }

        public Question GetQuestionById(int id)
        {
            return _Context.Questions.Find(id);
        }

        public bool UpdateQuestion(Question question)
        {
            try
            {
                _Context.Questions.Update(question);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
