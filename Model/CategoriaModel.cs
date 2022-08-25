using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class CategoriaModel
    {
        public CategoriaModel()
        {
            Produtos = new Collection<ProdutoModel>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImageUrl { get; set; }
        public ICollection<ProdutoModel>? Produtos { get; set; }
    }
}