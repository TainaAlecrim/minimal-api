using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Dominio.Dominio.Entidades;

public class Veiculo
{
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required]
        [StringLength(255)]
        public string Nome { get; set; } = default!;
        
        [Required]
        [StringLength(80)]
        public string Marca { get; set; } = default!;

        public int Ano { get; set; } = default!;
}