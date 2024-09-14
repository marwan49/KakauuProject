using eKakauu.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKakauu.Models
{
    public class Chocolate
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string ChocolateProcessing { get; set; } //EX: chocolate 70%
        public string Flavor { get; set; }
        public string Validity { get; set; } //validade do produto
        public string imageURL { get; set; }
        public ChocolateType ChocolateTypek { get; set; }

        //Relationship
        [Required]
        public int CocoaId { get; set; }
        [ForeignKey("CocoaId")]
        public Cocoa Cocoa { get; set; }

    }
}
