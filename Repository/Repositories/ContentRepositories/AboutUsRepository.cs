using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly JotexDbContext _context;
        public AboutUsRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateAbout(AboutUs model)
        {
            model.CreatedAt = DateTime.Now;
            _context.AboutUs.Add(model);
            _context.SaveChanges();
        }

        public void CreateSetting(Settings model)
        {
            model.CreatedAt = DateTime.Now;
            model.CoverImage = "#";
            _context.Settings.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAbout(AboutUs abs)
        {
            _context.AboutUs.Remove(abs);
            _context.SaveChanges();
        }

        public void DeleteFag(Settings setting)
        {
            _context.Settings.Remove(setting);
            _context.SaveChanges();
        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status)
                                  .Include("Settings")
                                  .ToList();
        }

        public IEnumerable<AboutUs> GetAboutUsAll()
        {
            return _context.AboutUs.ToList();
        }

        public AboutUs GetAboutUsById(int id)
        {
            return _context.AboutUs.Find(id);
        }

        public IEnumerable<Settings> GetAllSettings()
        {
            return _context.Settings.ToList();
        }

        public Settings GetSettingById(int id)
        {
            return _context.Settings.Find(id);
        }

        public Settings GetSettings()
        {
            return _context.Settings.FirstOrDefault(s => s.Status);
        }

        public void UpdateAboutUs(AboutUs aboutUsToUpdate, AboutUs model)
        {
            aboutUsToUpdate.About = model.About;
            aboutUsToUpdate.Text = model.Text;
            aboutUsToUpdate.Title = model.Title;
            aboutUsToUpdate.SubTitle = model.SubTitle;
            aboutUsToUpdate.ClaimPercent = model.ClaimPercent;
            aboutUsToUpdate.ClaimText = model.ClaimText;
            aboutUsToUpdate.PolicyCount = model.PolicyCount;
            aboutUsToUpdate.PolicyText = model.PolicyText;
            aboutUsToUpdate.OfficeCount = model.OfficeCount;
            aboutUsToUpdate.OfficeText = model.OfficeText;
            aboutUsToUpdate.ClaimActionText = model.OfficeActionText;
            aboutUsToUpdate.PolicyActionText = model.OfficeActionText;
            aboutUsToUpdate.Status = model.Status;
            aboutUsToUpdate.SettingsId = model.SettingsId;
            aboutUsToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }

        public void UpdateFag(Settings settingToUpdate, Settings model)
        {
            settingToUpdate.Status = model.Status;
            settingToUpdate.Logo = model.Logo;
            settingToUpdate.Phone = model.Phone;
            settingToUpdate.QueryNumber = model.QueryNumber;
            settingToUpdate.WorkTime = model.WorkTime;
            settingToUpdate.Email = model.Email;
            settingToUpdate.Adress = model.Adress;
            settingToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();

        }
    }
}
