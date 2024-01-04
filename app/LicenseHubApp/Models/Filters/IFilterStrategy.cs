namespace LicenseHubApp.Models.Filters;

public interface IFilterStrategy<TModel>
{
    IEnumerable<TModel> Filter(IEnumerable<TModel> models, string filterValue);
}