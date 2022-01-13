using System;
using System.Runtime.Serialization;

namespace Catalog.Dtos
{
    [DataContract]
    public record ItemDto
    {
        #region Constructor 

        /// <summary>
        /// Constructor Default
        /// </summary>
        public ItemDto() { }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="createdDate"></param>
        public ItemDto(Guid id, string name, decimal price, DateTimeOffset createdDate)
        {
            Id = id;
            Name = name;
            Price = price;
            CreatedDate = createdDate;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Identifiant objet
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; init; }

        /// <summary>
        /// Nom de l'objet
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; init; }

        /// <summary>
        /// Prix de l'objet
        /// </summary>
        [DataMember(Name = "price")]
        public decimal Price { get; init; }

        /// <summary>
        /// Date de cr�ation
        /// </summary>
        [DataMember(Name = "createdDate")]
        public DateTimeOffset CreatedDate { get; init; }

        #endregion
    }
}