using FreeTestManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeTest.Services
{
    internal class PassingTestManager
    {
        private Test test { get; set; }

        public PassingTestManager(Test test)
        {
            this.test = test;
        }

        public bool CheckAnswer(Guid questionId, Guid answerId)
        {
            var question = findQuestion(questionId);

            var answer = question.Answers
                .FirstOrDefault(x => x.Id == answerId);

            if (answer is null)
            {
                throw new Exception("нет question с id = " + questionId.ToString());
            }

            return answer.IsTrue;
        }

        public List<KeyValuePair<Guid,bool>> CheckAnswers(Guid questionId, List<Guid> answerIds)
        {
            var question = findQuestion(questionId);

            return answerIds
                    .Select(x => new KeyValuePair<Guid, bool>(x, CheckAnswer(questionId, x)))
                    .ToList();
        }

        private Question findQuestion(Guid id)
        {
            var question = test.Questions.FirstOrDefault(x => x.Id == id);

            if (question is null)
            {
                throw new Exception("нет question с id = " + id.ToString());
            }

            return question;
        }

        public List<Question> GetQuestions()
        {
            return test.Questions;
        }
    }
}
