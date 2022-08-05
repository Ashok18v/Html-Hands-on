using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAndDatabase.Entities
{
    public class Books
    {
       
        public int Id { get; set; }
        [Column(TypeName = "Varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Zoner { get; set; }
        [DataType(DataType.Date)]
        public DateTime Release_Date { get; set; }
        [Column(TypeName = "Varchar(8)")]
        public int Cost { get; set; }
        [Column(TypeName = "Varchar(Max)")]
        public string Image { get; set; }


    }
}
