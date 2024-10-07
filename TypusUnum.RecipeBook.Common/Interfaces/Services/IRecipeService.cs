using TypusUnum.RecipeBook.Common.Models;

namespace TypusUnum.RecipeBook.Common.Interfaces.Services;

public interface IRecipeService
{
    PaginatedResult<Recipe> Search(RecipeSearchObject recipeSearchObject);

    Recipe GetSingle(
        Guid recipeId,
        bool includeIngredients = false,
        bool includeSteps = false,
        bool includeHistory = false,
        bool includeOriginal = false
    );

    ServiceResult<Recipe> Post(Recipe recipe);

    ServiceResult<Recipe> Put(Recipe recipe);

    ServiceResult<Recipe> Fork(Guid recipeId, Guid accountId);

    bool Delete(Guid recipeId);
}