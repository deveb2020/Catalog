using System;
using System.Collections.Generic;
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
		Item GetItem(Guid id);

		/// <summary>
		/// Get a list of Items
		/// </summary>
		/// <returns>Enumerable items</returns>
		IEnumerable<Item> GetItems();

		/// <summary>
		/// Creation of Item
		/// </summary>
		/// <param name="item">Item</param>
		void CreateItem(Item item);

		/// <summary>
		/// Update Item
		/// </summary>
		/// <param name="item">Item</param>
		void UpdateItem(Item item);

		/// <summary>
		/// Delete Item
		/// </summary>
		/// <param name="id"></param>
		void DeleteItem(Guid id);
	}
}