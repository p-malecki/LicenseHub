using LicenseHubApp.Models;

namespace LicenseHubApp.Services.Managers
{
    public class BaseModelManager<TModel> where TModel : ValidatableModel, IModelWithId
    {
        protected static IModelRepository<TModel> Repository;
        protected IEnumerable<TModel> ModelList;

        public void LoadAll()
        {
            ModelList = Repository.GetAllAsync().Result.ToList();
        }

        public IEnumerable<TModel> GetAll()
        {
            LoadAll();
            return ModelList;
        }

        public TModel GetModelById(int id)
        {
            return Repository.GetModelByIdAsync(id).Result!;
        }


        public void Add(TModel model)
        {
            try
            {
                if (model.Validate())
                {
                    // TODO (?) resign from async
                    Task.Run(async () =>
                    {
                        await Repository.AddAsync(model);
                    }).Wait();
                    LoadAll();
                }
                else
                {
                    throw new InvalidOperationException("Model validation failed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void Save(TModel model)
        {
            try
            {
                if (model.Validate())
                {
                    if (!Repository.IsIdUnique(model.Id))
                    {
                        Task.Run(async () =>
                        {
                            await Repository.EditAsync(model.Id, model);
                        }).Wait();
                        LoadAll();
                    }
                    else
                    {
                        var objType = model.GetType();
                        throw new InvalidOperationException($"{objType.Name} with ID {model.Id} does not exist.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Model validation failed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void Delete(TModel model)
        {
            try
            {
                if (!Repository.IsIdUnique(model.Id))
                {
                    Task.Run(async () =>
                    {
                        await Repository.DeleteAsync(model.Id);
                    }).Wait();
                    LoadAll();
                }
                else
                {
                    var objType = model.GetType();
                    throw new InvalidOperationException($"{objType.Name} with ID {model.Id} does not exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
