using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectEntityFramework.Models.EfTestModel
{
[Table("student")]
    public class Student
    {
        [Key]
        public int sid { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
    }
}