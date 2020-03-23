using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products.Public
{
	public class GetProductPagingRequest2:PagingRequestBase
	{
		public int? CategoryId { get; set; }
	}
}
