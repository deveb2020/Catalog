using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Repositories
{
	public class InMemItemsRepository : IItemsRepository
	{
		private readonly List<Item> items = new()
		{
			new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
			new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
			new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow },
		};

	// GET ITEMS
		public IEnumerable<Item> GetItems()
		{
			return items;
		}

	// GET ITEM
		public Item GetItem(Guid id)
		{
			return items.Where(item => item.Id == id).SingleOrDefault();
		}

		// CREATE ITEM
		public void CreateItem(Item item)
		{
			items.Add(item);
		}

		// UPDATE ITEM
		public void UpdateItem(Item item)
		{
			var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
			items[index] = item;
		}

		// DELETE ITEM
		public void DeleteItem(Guid id)
		{
			var index = items.FindIndex(existingItem => existingItem.Id == id);
			items.RemoveAt(index);
		}
	}
}