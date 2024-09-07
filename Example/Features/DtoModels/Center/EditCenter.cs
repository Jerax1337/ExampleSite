using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Example.Features.DtoModels.Center
{
    public sealed record EditCenter
    {
        [Required]
        public Guid IsnNode { get; init; }

        [Required, MaxLength(20)]
        public string Code { get; init; }

        [Required, MaxLength(255)]
        public string Name { get; init; }
    }
}
