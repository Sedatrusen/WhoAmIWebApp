
using System.Collections.ObjectModel;


namespace WhoAmIWebApp.Models
{
    public class MyUser 
    {
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public  string Mail { get; set; }
        public string Password { get; set; }

        public  Collection<Quiz>? Quizzes { get; set; }
        public UserType UserType { get; set; }
      
    }
}
