using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentAPIdemo.Models
{
    public class Student
    {
        [Key]
        public string RollNo { get; set; }
        public string Name { get; set; }    
    }
}
