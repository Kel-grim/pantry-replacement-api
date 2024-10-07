using TypusUnum.RecipeBook.Common.Models;

namespace TypusUnum.RecipeBook.Common.Interfaces.Repositories;

public interface IRecipeRepository
{
    PaginatedResult<Recipe> Search(RecipeSearchObject recipeSearchObject);

    Recipe GetSingle(
        Guid recipeId,
        bool includeHistory = false
    );

    bool Post(Recipe recipe);

    bool Put(Recipe recipe);

    bool Fork(Guid recipeId, Guid accountId);

    bool Delete(Guid recipeId);
}