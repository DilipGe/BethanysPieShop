using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        public readonly IPieRepository _pieRepository;
        public readonly ICategoryRepository _categoryRepository;
        
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ActionResult List()
        {
            PiesListViewModel viewModel = new PiesListViewModel();
            viewModel.Pies = _pieRepository.Pies;
            viewModel.CurrentCategary = "Cheese Cakes";
            return View(viewModel);
        }
    }
}
