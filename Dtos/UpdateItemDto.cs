using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
			[RequiredAttribute]
			public string Name { get; init;}

			[RequiredAttribute]
			[Range(1, 1000)]
			public decimal Price { get; init;}
    }
}