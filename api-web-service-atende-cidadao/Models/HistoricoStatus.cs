using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace api_web_service_atende_cidadao.Models
{
    [Table("HistoricoStatus")]
    public class HistoricoStatus
    {
        [Key]
        public int Id { get; set; }

        public int SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; }

        public Solicitacao.StatusSolicitacao Status { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
