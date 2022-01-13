using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    /// <summary>
    /// Classe d'extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// permet de transformer un Item en ItemDto
        /// </summary>
        /// <param name="item">Item</param>
        /// <returns>Retourne un ItemDto</returns>
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Price, item.CreatedDate);
        }
    }
}