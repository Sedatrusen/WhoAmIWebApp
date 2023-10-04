
namespace WhoAmIWebApp.Models
{
    public class Answer 
    {
        public required string Body {  get; set; }
        public bool IsTrue { get; set; }
        public bool IsSelected { get; set; }

        public int QuestionId { get; set; }
    }
}
