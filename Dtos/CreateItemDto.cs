using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Catalog.Dtos
{
    // mot record permet de verifier si deux objets sont different en valeur
    [DataContract]
    public record CreateItemDto
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember(Name = "name")]
        [Required]
        public string Name { get; init; }

        /// <summary>
        /// price
        /// </summary>
        [DataMember(Name = "price")]
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}