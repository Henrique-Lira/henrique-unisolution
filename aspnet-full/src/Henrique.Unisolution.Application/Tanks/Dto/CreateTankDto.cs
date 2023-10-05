using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Henrique.Unisolution.Tanks.Dto
{
    [AutoMapTo(typeof(Tank))]
    public class CreateTankDto
    {
        [Required]
        [StringLength(Tank.MaxIdLength)]
        public string Id { get; set; }

        public decimal Capacity { get; set; }

        [Required]
        [StringLength(Tank.MaxProductTypeLength)]
        public string ProductType { get; set; }
    }
}
