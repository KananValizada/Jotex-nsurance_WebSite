using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBestServicesRepository
    {
        IEnumerable<Service> getBestServices(int count);
        Blog  GetBlogById(int Id);

        void PostBlogComment(BlogComment comment);
        IEnumerable<Service> getServices();
    }
}
