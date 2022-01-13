using System;
using System.Runtime.Serialization;

namespace Catalog.Entities
{
	[DataContract]
	public record Item
	{
		/// <summary>
		/// Identifiant objet
		/// </summary>
		[DataMember(Name= "id")]
		public Guid Id { get; init;}

		/// <summary>
		/// Nom de l'objet
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; init;}

		/// <summary>
		/// Prix de l'objet
		/// </summary>
		[DataMember(Name = "price")]
		public decimal Price { get; init;}

		/// <summary>
		/// Date de création
		/// </summary>
		[DataMember(Name = "createdDate")]
		public DateTimeOffset CreatedDate { get; init;}
	}
}