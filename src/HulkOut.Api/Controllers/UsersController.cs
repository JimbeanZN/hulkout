using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HulkOut.Shared.Interfaces.Users;
using HulkOut.Shared.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace HulkOut.Api.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class UsersController : Controller
	{
		private readonly IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		// GET api/users
		[HttpGet]
		public async Task<IEnumerable<User>> Get()
		{
			return await _userService.GetAll(null);
		}

		// GET api/users/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public async Task<User> Get(Guid id)
		{
			return await _userService.Get(id);
		}

		// POST api/users
		[HttpPost]
		public async void Post([FromBody] User model)
		{
			await _userService.Insert(model);
		}

		// PUT api/users/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpPut("{id}")]
		public async void Put(Guid id, [FromBody] User model)
		{
			await _userService.Update(model);
		}

		// DELETE api/users/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpDelete("{id}")]
		public async void Delete(Guid id)
		{
			await _userService.Delete(id);
		}
	}
}