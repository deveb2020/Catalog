using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Entities;

namespace Catalog.Repositories
{
	/// <summary>
	/// Interface of Item repository
	/// </summary>
	public interface IItemsRepository
	{
		/// <summary>
		/// Get Item
		/// </summary>
		/// <param name="id">Identifiant</param>
		/// <returns>Item</returns>
		Task<Item> GetItemAsync(Guid id);

		/// <summary>
		/// Get a list of Items
		/// </summary>
		/// <returns>Enumerable items</returns>
		Task<IEnumerable<Item>> GetItemsAsync();

		/// <summary>
		/// Creation of Item
		/// </summary>
		/// <param name="item">Item</param>
		Task CreateItemAsync(Item item);

		/// <summary>
		/// Update Item
		/// </summary>
		/// <param name="item">Item</param>
		Task UpdateItemAsync(Item item);

		/// <summary>
		/// Delete Item
		/// </summary>
		/// <param name="id"></param>
		Task DeleteItemAsync(Guid id);
	}
}