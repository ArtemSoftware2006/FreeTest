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
        public bool CheckMultiAnswers(Guid questionId, List<Guid> answerIds)
        {
            var question = findQuestion(questionId);

            int actualCount = answerIds
                .Select(x => new KeyValuePair<Guid, bool>(x, CheckAnswer(questionId, x)))
                .Where(x => x.Value)
                .Count();

            int expectedCount = question
                .Answers
                .Where(x => x.IsTrue)
                .Count();

            return actualCount == expectedCount;
        }
        public List<KeyValuePair<Guid,bool>> CheckEverMultiAnswers(Guid questionId, List<Guid> answerIds)
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

        public List<KeyValuePair<Guid, bool>> ReportAnswers(Guid questionId, 
            List<KeyValuePair<Guid, bool>> checkedAnswers )
        {
            var question = findQuestion(questionId);
            var trueAnswers = question
                .Answers
                .Where(x => x.IsTrue)
                .Select(x => new KeyValuePair<Guid, bool>(x.Id, x.IsTrue));

            return checkedAnswers.Union(trueAnswers).ToList();
        }
    }
}
