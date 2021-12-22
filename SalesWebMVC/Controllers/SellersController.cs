using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Services;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellersService;

        public SellersController(SellerService sellerService)
        {
            _sellersService = sellerService;
        }

        public IActionResult Index()
        {
            List<Seller> list = _sellersService.FindAll();
            return View(list);
        }
    }
}
