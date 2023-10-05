using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Henrique.Unisolution.Tanks.Dto
{
    [AutoMap(typeof(Tank))] 
    public class TankDto: FullAuditedEntityDto<string>
    {
        public decimal Capacity { get; set; }

        [Required(ErrorMessage = "Product Type is required.")]
        [StringLength(Tank.MaxProductTypeLength, ErrorMessage = "Product Type must be at most {1} characters.")]
        public string ProductType { get; set; }
    }
}
