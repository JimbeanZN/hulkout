using System;
using System.Collections.Generic;
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
		public IEnumerable<User> Get()
		{
			return _userService.GetAll(null);
		}

		// GET api/users/63AAB81D-3EB5-4564-849A-28260B523FE4
		[HttpGet("{id}")]
		public User Get(Guid id)
		{
			return _userService.Get(id);
		}
	}
}