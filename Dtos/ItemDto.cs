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
        /// object Idendity
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; init; }

        /// <summary>
        /// object name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; init; }

        /// <summary>
        /// object price
        /// </summary>
        [DataMember(Name = "price")]
        public decimal Price { get; init; }

        /// <summary>
        /// Date creation
        /// </summary>
        [DataMember(Name = "createdDate")]
        public DateTimeOffset CreatedDate { get; init; }

        #endregion
    }
}