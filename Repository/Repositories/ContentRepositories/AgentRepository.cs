using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IAgentRepository
    {
        IEnumerable<Agent> GetAgents(int count);
    }
    public class AgentRepository : IAgentRepository
    {
        private readonly JotexDbContext _context;
        public AgentRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Agent> GetAgents(int count)
        {
            return _context.Agents.Where(a => a.Status).Take(count).ToList();
        }
    }
}
