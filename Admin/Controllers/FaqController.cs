using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class FaqController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IFagRepository _fagRepository;
        public FaqController(IMapper mapper,IFagRepository fagRepository)
        {
            _mapper = mapper;
            _fagRepository = fagRepository;
        }
        public IActionResult Index()
        {
            var fags = _fagRepository.GetAllFags();
            var model = _mapper.Map<IEnumerable<Fag> , IEnumerable<FagViewModel>>(fags);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FagViewModel fag)
        {
            if (ModelState.IsValid)
            {
                Fag model = _mapper.Map<FagViewModel, Fag>(fag);
                model.CreatedBy = _admin.FullName;
                _fagRepository.CreateFag(model);
                return RedirectToAction("index");
            }
            return View(fag);
        }
        public IActionResult Edit(int id)
        {
            Fag fag = _fagRepository.GetFagById(id);
            if (fag == null) return NotFound();
            var model = _mapper.Map<Fag, FagViewModel>(fag);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FagViewModel fag)
        {
            if (ModelState.IsValid)
            {
                Fag model = _mapper.Map<FagViewModel, Fag>(fag);
                model.ModifiedBy = _admin.FullName;
                Fag fagToUpdate = _fagRepository.GetFagById(fag.Id);
                if (fagToUpdate == null) return NotFound();
                _fagRepository.UpdateFag(fagToUpdate, model);
                return RedirectToAction("index");
            }
            return View(fag);
        }
        public IActionResult Delete(int id)
        {
            Fag fag = _fagRepository.GetFagById(id);
            if (fag == null) return NotFound();
            _fagRepository.DeleteFag(fag);
            return RedirectToAction("index");
        }

    }
}