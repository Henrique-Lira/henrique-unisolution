using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Henrique.Unisolution.Tanks
{
    [Table("Tanks")]
    public class Tank: FullAuditedEntity<string>
    {
        public const int MaxIdLength = 512;
        public const int MaxProductTypeLength = 256;

        [Column("Deposito")]
        [StringLength(MaxIdLength)]
        public override string Id { get; set; }

        [Column("Capacidade")]
        public decimal Capacity { get; set; }

        [Required]
        [Column("TipoDeProduto")]
        [StringLength(MaxProductTypeLength)]
        public string ProductType { get; set; }
    }
}
