using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface ILikeableAreaRepository
    {
        IEnumerable<LikeableArea> GetLikeableAreas();

    }
    public interface IClaimSettlementRepository
    {
        IEnumerable<ClaimSettlement> GetClaimSettlements();

    }
    public class LikeableAreaRepository : ILikeableAreaRepository
    {
        private readonly JotexDbContext _context;
        public LikeableAreaRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LikeableArea> GetLikeableAreas()
        {
            return _context.LikeableArea.Where(l => l.Status).ToList();
        }

    }
    public class ClaimSettlementRepository : IClaimSettlementRepository
    {
        private readonly JotexDbContext _context;
        public ClaimSettlementRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ClaimSettlement> GetClaimSettlements()
        {
            return _context.ClaimSettlement.Where(c => c.Status)
                                           .Include("ClaimSettlementOptions")
                                           .ToList();
        }



    }
}
