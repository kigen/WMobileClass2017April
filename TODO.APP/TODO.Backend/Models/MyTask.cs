using System;

namespace TODO.Backend.Models
{
   public class MyTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }

       public string CompleteText
       {
           get { return Complete ? "Complete" : "Incomplete"; }
       }
    }
}
