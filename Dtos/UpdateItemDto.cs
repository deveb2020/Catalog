using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Catalog.Dtos
{
    /// <summary>
    /// Class Update Item
    /// </summary>
    [DataContract]
    public record UpdateItemDto
    {
        /// <summary>
        /// Name updated
        /// </summary>
        [Required]
        public string Name { get; init; }

        /// <summary>
        /// Price updated
        /// </summary>
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}