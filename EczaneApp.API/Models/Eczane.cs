using System.ComponentModel.DataAnnotations.Schema;

namespace EczaneApp.API.Models
{
    [Table("Eczane")]
    public class Eczane
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}