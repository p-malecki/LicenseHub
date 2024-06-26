﻿
namespace LicenseHubApp.Models.Filters
{
    public class CustomerNameFilterStrategy : IFilterStrategy<CompanyModel>
    {
        public IEnumerable<CompanyModel> Filter(IEnumerable<CompanyModel> models, string filterValue)
        {
            return models.Where(m => m.Name.Contains(filterValue, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
