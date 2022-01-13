using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;
using Catalog.Dtos;
using System.Threading.Tasks;

namespace Catalog.Controllers
{
    /// <summary>
    /// Controller of items
    /// </summary>
    [ApiController]
    [Route("Items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get a list of items
        /// </summary>
        /// <returns>List of items</returns>
        [HttpGet]
        public async Task<IEnumerable<ItemDto>> GetItemsAsync()
        {
            var items = (await repository.GetItemsAsync())
                            .Select(item => item.AsDto());

            return items;
        }

        /// <summary>
        /// Get a specific Item 
        /// </summary>
        /// <param name="id">Identy</param>
        /// <returns>return a item</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDto>> GetItemAsync(Guid id)
        {
            var item = await repository.GetItemAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            return item.AsDto();
        }

        /// <summary>
        /// Create a Item
        /// </summary>
        /// <param name="itemDto">a object ItemDto</param>
        /// <returns>a object item</returns>
        [HttpPost]
        public async Task<ActionResult<ItemDto>> CreateItemAsync(CreateItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };

            await repository.CreateItemAsync(item);

            return CreatedAtAction(nameof(GetItemAsync), new { id = item.Id }, item.AsDto());
        }


        /// <summary>
        /// Update a Item
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <param name="itemDto">object itemDto</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateItem(Guid id, UpdateItemDto itemDto)
        {
            var existingItem = await repository.GetItemAsync(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            var updatedItem = existingItem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price
            };

            await repository.UpdateItemAsync(updatedItem);

            return NoContent();
        }

        /// <summary>
        /// Delete a Item
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns></returns>
        [HttpDelete("{id}")]

        public async Task<ActionResult> DeleteItemAsync(Guid id)
        {
            var existingItem = await repository.GetItemAsync(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            await repository.DeleteItemAsync(id);

            return NoContent();
        }
    }
}