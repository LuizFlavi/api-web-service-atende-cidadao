using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_web_service_atende_cidadao.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Texto { get; set; }

        public DateTime DataCriacao { get; set; }

        public int SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } 
    }
}
