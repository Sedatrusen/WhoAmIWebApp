

using System.Collections.ObjectModel;


namespace WhoAmIWebApp.Models
{
    public  class Quiz 
    {
        public int UserId { get; set; }
        public required Collection<Question> Questions { get; set; }
        public QuizType QuizType { get; set; }
    }
}
