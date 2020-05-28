using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IFagRepository
    {
        IEnumerable<Fag> GetFags();
        IEnumerable<Fag> GetAllFags();
        Fag CreateFag(Fag model);
        Fag GetFagById(int id);
        void UpdateFag(Fag fagToUpdate, Fag model);
        void DeleteFag(Fag fag);
    }
}
