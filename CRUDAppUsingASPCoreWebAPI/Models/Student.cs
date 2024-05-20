using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models
{
    public class Student
    {
       
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string fname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string mobile { get; set; }
        [Required]
        public string description { get; set; }
       



    }
}
