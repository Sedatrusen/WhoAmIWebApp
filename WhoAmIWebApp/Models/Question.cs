
using System.Collections.ObjectModel;


namespace WhoAmIWebApp.Models
{
    public class Question
    {
        public  string Body { get; set; }
        public  Collection<Answer> Answers {  get; set; }
     
        public  int QuizId { get; set; }

        

    }
}
