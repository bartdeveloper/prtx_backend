﻿using prtx_backend.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace prtx_backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET")]
    public class SearchController : ApiController
    {

        // GET api/search/query
        public async Task<IEnumerable<Product>> Get(string query)
        {

            SearchEngine se = new SearchEngine();
            var searchingProducts = await se.searchProducts(query);

            return searchingProducts;

        }

    }
}
