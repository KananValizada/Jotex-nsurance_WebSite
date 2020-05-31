using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AgentController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IAgentRepository _agentRepository;
        private readonly IBestServicesRepository _servicesRepository;
        public AgentController(IMapper mapper, IAgentRepository agentRepository, IBestServicesRepository servicesRepository)
        {
            _mapper = mapper;
            _agentRepository = agentRepository;
            _servicesRepository = servicesRepository;
        }
        public IActionResult Index()
        {
            var agents = _agentRepository.GetAllAgents();
            var model = _mapper.Map<IEnumerable<Agent>, IEnumerable<AgentViewModel>>(agents);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Service = _servicesRepository.getServices();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AgentViewModel abs)
        {
            if (ModelState.IsValid)
            {
                Agent model = _mapper.Map<AgentViewModel, Agent>(abs);
                model.CreatedBy = _admin.FullName;
                _agentRepository.CreateAgent(model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Edit(int id)
        {
            Agent abs = _agentRepository.GetAgentById(id);
            if (abs == null) return NotFound();
            var model = _mapper.Map<Agent, AgentViewModel>(abs);
            ViewBag.Service = _servicesRepository.getServices();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgentViewModel abs)
        {
            if (ModelState.IsValid)
            {
                Agent model = _mapper.Map<AgentViewModel, Agent>(abs);
                model.ModifiedBy = _admin.FullName;
                Agent AgentToUpdate = _agentRepository.GetAgentById(abs.Id);
                if (AgentToUpdate == null) return NotFound();

                _agentRepository.UpdateAgent(AgentToUpdate, model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
           
            Agent abs = _agentRepository.GetAgentById(id);
            if (abs == null) return NotFound();
            _agentRepository.DeleteAgent(abs);
            return RedirectToAction("index");
        }
    }
}