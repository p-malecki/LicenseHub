﻿using Microsoft.EntityFrameworkCore;
using LicenseHubApp.Models;


namespace LicenseHubApp.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }

        public async Task AddAsync(ProductModel model)
        {
            try
            {
                model.ThrowIfNotValid();
                if (!IsNameUnique(model.Id, model.Name))
                {
                    throw new InvalidDataException("Product has not unique name.");
                }

                context.Products.Add(model);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int modelId)
        {
            var modelToDelete = await GetModelByIdAsync(modelId);
            if (modelToDelete != null)
            {
                context.Products.Remove(modelToDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int modelId, ProductModel updatedModel)
        {
            var modelToUpdate = await GetModelByIdAsync(modelId);

            if (modelToUpdate != null)
            {
                updatedModel.ThrowIfNotValid();
                if (!IsNameUnique(modelId, updatedModel.Name))
                {
                    throw new InvalidDataException("Product has not unique name.");
                }

                modelToUpdate.Name = updatedModel.Name;
                modelToUpdate.IsAvailable = updatedModel.IsAvailable;

                await context.SaveChangesAsync();
            }
        }

        public async Task<ProductModel?> GetModelByIdAsync(int modelId)
        {
            return await context.Products.FirstOrDefaultAsync(m => m.Id == modelId);
        }

        public async Task<IList<ProductModel>> GetAllAsync()
        {
            return await context.Products.ToListAsync();
        }

        public bool IsIdUnique(int modelId)
        {
            return !context.Products.Any(model => model.Id == modelId);
        }
        public bool IsNameUnique(int modelId, string modelName)
        {
            return !context.Products.Any(model => (model.Name == modelName) && model.Id != modelId);
        }

        public async Task AddReleaseAsync(int productId, ProductReleaseModel releaseModel)
        {
            try
            {
                releaseModel.ThrowIfNotValid();

                var modelToUpdate = context.Products
                                        .Include(m => m.Releases)
                                        .First(m => m.Id == productId)
                                    ?? throw new NullReferenceException("Product model not found.");

                modelToUpdate.Releases.Add(releaseModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task RemoveReleaseAsync(int productId, ProductReleaseModel releaseModel)
        {
            try
            {
                var productModel = await GetModelByIdAsync(productId) ?? throw new NullReferenceException("Product model not found.");

                productModel.Releases.Remove(releaseModel);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
