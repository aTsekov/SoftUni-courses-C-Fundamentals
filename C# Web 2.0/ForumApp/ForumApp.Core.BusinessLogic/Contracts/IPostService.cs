﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Core.BusinessLogic.Models;

namespace ForumApp.Core.BusinessLogic.Contracts
{
	public interface IPostService
	{
		Task<List<PostViewModel>> GetAllPostsAsync();
		Task AddPostAsync(PostFormModel model);
		//Task EditProductAsync(ProductFormModel model);
		//Task DeleteProductAsync(ProductFormModel model);
	}
}
