using System.ComponentModel.DataAnnotations;

namespace ApiAndDatabase
{
    public class ModelApiBook
    {
        public int Id { get; set; }
     
        public string Name { get; set; }
  
        public string Zoner { get; set; }
        [DataType(DataType.Date)]
        public DateTime Release_Date { get; set; }

        public int Cost { get; set; }

        public string Image { get; set; }
    }
}
