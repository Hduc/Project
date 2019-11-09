using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.DataAccess;
using WebApp.Business;

namespace WebApp.GUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController (IProductBusiness productBusiness)
        {
            this._productBusiness = productBusiness;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_productBusiness.GetAll());
        }
    }
}