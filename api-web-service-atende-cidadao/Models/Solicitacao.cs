using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_web_service_atende_cidadao.Models
{
    [Table("Solicitacoes")]
    public class Solicitacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }  

        public enum StatusSolicitacao
        {
            Pendente,
            EmAndamento,
            Concluida,
            Cancelada
        }

        public StatusSolicitacao Status { get; set; } = StatusSolicitacao.Pendente;

        public int UsuarioId { get; set; }  // ID do usuário que fez a solicitação
        public Usuario Usuario { get; set; }  // Navegação para o usuário
    }

}