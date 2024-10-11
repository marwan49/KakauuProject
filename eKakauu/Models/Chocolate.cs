using eKakauu.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKakauu.Models
{
    public class Chocolate
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome não pode ser vazio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo processamento não pode ser vazio.")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "O processamento deve ter ate 2 caracteres.")]
        public string ChocolateProcessing { get; set; }

        [Required(ErrorMessage = "Campo sabor não pode ser vazio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O sabor deve ter entre 2 e 50 caracteres.")]
        public string Flavor { get; set; }

        [Required(ErrorMessage = "Campo validade não pode ser vazio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A validade deve ter entre 2 e 50 caracteres.")]
        public string Validity { get; set; }

        [Required(ErrorMessage = "Campo preço não pode ser vazio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public double price { get; set; }

        [Required(ErrorMessage = "Campo URL da imagem não pode ser vazio.")]
        [Url(ErrorMessage = "URL da imagem inválida.")]
        public string imageURL { get; set; }

        [Required(ErrorMessage = "Campo tipo de chocolate não pode ser vazio.")]
        public ChocolateType ChocolateTypek { get; set; }

        // Relationship
        [Required]
        public int CocoaId { get; set; }

        [ForeignKey("CocoaId")]
        public Cocoa? Cocoa { get; set; }
    }
}
