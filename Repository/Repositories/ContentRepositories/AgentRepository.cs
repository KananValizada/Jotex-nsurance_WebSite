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
        IEnumerable<Agent> GetAllAgents();
        void CreateAgent(Agent model);
        Agent GetAgentById(int id);
        void UpdateAgent(Agent agentToUpdate, Agent model);
        void DeleteAgent(Agent abs);
    }
    public class AgentRepository : IAgentRepository
    {
        private readonly JotexDbContext _context;
        public AgentRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateAgent(Agent model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Agents.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgent(Agent abs)
        {
            _context.Agents.Remove(abs);
            _context.SaveChanges();
        }

        public Agent GetAgentById(int id)
        {
            return _context.Agents.Find(id);
        }

        public IEnumerable<Agent> GetAgents(int count)
        {
            return _context.Agents.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return _context.Agents.ToList();
        }

        public void UpdateAgent(Agent agentToUpdate, Agent model)
        {
            agentToUpdate.Status = model.Status;
            agentToUpdate.Name = model.Name;
            agentToUpdate.ServiceId = model.ServiceId;
            agentToUpdate.Image = model.Image;
            agentToUpdate.Profession = model.Profession;
            agentToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
