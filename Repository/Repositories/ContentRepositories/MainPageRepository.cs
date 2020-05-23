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
    public interface ITestimonialsRepository
    {
        IEnumerable<Testimonial> GetTestimonials();

    }
    public interface IAwardsRepository
    {
        IEnumerable<Award> GetAwards();

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
    public class TestimonialsRepository : ITestimonialsRepository
    {
        private readonly JotexDbContext _context;
        public TestimonialsRepository(JotexDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(t => t.Status)
                                        .ToList();
        }
    }
    public class AwardsRepository : IAwardsRepository
    {
        private readonly JotexDbContext _context;
        public AwardsRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Award> GetAwards()
        {
            return _context.Awards.Where(a => a.Status).ToList();
        }
    }
}
