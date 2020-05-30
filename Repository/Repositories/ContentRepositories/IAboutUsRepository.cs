using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IAboutUsRepository 
    {
        IEnumerable<AboutUs> GetAboutUs();
        Settings GetSettings();
        void CreateSetting(Settings model);
        Settings GetSettingById(int id);
        void UpdateFag(Settings settingToUpdate, Settings model);
        IEnumerable<Settings> GetAllSettings();
        void DeleteFag(Settings setting);
        void CreateAbout(AboutUs model);
        IEnumerable<AboutUs> GetAboutUsAll();
        AboutUs GetAboutUsById(int id);
        void UpdateAboutUs(AboutUs aboutUsToUpdate, AboutUs model);
        void DeleteAbout(AboutUs abs);
    }
}
