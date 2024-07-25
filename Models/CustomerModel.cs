using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mysampleapp.Models
{
    public class CustomerModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
