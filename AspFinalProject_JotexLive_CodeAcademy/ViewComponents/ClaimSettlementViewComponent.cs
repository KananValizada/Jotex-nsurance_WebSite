using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.ViewComponents
{
    public class ClaimSettlementViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IClaimSettlementRepository _claimSettlementRepository;
        public ClaimSettlementViewComponent(IMapper mapper, IClaimSettlementRepository claimSettlementRepository)
        {
            _mapper = mapper;
            _claimSettlementRepository = claimSettlementRepository;
        }
        public IViewComponentResult Invoke()
        {
            var claimSettlement = _claimSettlementRepository.GetClaimSettlements();

            var model = _mapper.Map<IEnumerable<ClaimSettlement>, IEnumerable<ClaimSettlementViewModel>>(claimSettlement);

            return View(model);
        }
    }
}
