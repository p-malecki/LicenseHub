namespace LicenseHubApp.Models.Managers
{
    public class BaseModelManager<TModel> where TModel: ValidatableModel, IModelWithId
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
            return Repository.GetModelByIdAsync(id).Result;
        }


        public void Add(TModel model)
        {
            try
            {
                if (model.Validate())
                    _ = Repository.AddAsync(model);
                else
                    throw new InvalidOperationException("Model validation failed.");
                LoadAll();

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
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
                        _ = Repository.EditAsync(model.Id, model);
                    }
                    else
                    {
                        Type objtype = model.GetType();
                        throw new InvalidOperationException($"{objtype.Name} with ID {model.Id} does not exist.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Model validation failed.");
                }
                LoadAll();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
        public void Delete(TModel model)
        {
            try
            {
                if (!Repository.IsIdUnique(model.Id))
                {
                    var a = Repository.DeleteAsync(model.Id);
                }
                else
                {
                    Type objtype = model.GetType();
                    throw new InvalidOperationException($"{objtype.Name} with ID {model.Id} does not exist.");
                }
                LoadAll();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                throw;
            }
        }
    }
}
