

namespace WhoAmIWebApp.Models
{
    public class QuizResult 
    {
        public string AnswererName { get; set; }
        public int TrueAnswer {  get; set; }
        public int FalseAnswer { get; set; }
        public int QuizId { get; set; }
    }
}
