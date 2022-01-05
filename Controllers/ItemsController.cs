using System;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;
using Catalog.Dtos;

namespace Catalog.Controllers
{
		[ApiController]
		[Route("Items")]
    public class ItemsController : ControllerBase
    {
      private readonly IItemsRepository repository;

			public ItemsController(IItemsRepository repository)
			{
				this.repository = repository;
			}

			// GET /items
			[HttpGet]
			public IEnumerable<ItemDto> GetItems()
			{	
				var items = repository.GetItems().Select( item => item.AsDto());

				return items;
			}

			// GET /items/{id}
			[HttpGet("{id}")]
			public ActionResult<ItemDto> GetItem(Guid id)
			{
				var item = repository.GetItem(id);
				
				if ( item is null ) 
				{
					return NotFound();
				}
				return item.AsDto();
			}
    }
}