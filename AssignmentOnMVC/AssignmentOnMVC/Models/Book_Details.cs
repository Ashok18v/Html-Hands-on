using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentOnMVC.Models
{
    public class Book_Details
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Name must not be more than 8 char")]
       
        public string Name { get; set; }
        [MaxLength(15, ErrorMessage = "Zoner must not be more than 8 char")]
        public string Zoner { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Release_Date { get; set; }

        public int Cost { get; set; }

        public string Image { get; set; }
    }
}
