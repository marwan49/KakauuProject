using eKakauu.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eKakauu.Models
{
    public class Cocoa
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public string Harvest { get; set; }
        public string Origin { get; set; } //onde foi plantado/colhido
        public string Description { get; set; }
        public CocoaType CocoaType { get; set; }

    }
}
