using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IFagRepository
    {
        IEnumerable<Fag> GetFags(int count);
    }
}
