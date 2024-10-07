namespace TypusUnum.RecipeBook.Common.Models;

public class RecipeIngredient
{
    public Guid RecipeIngredientId { get; set; }

    public Guid RecipeId { get; set; }

    public Guid RecipeStepId { get; set; }

    public Guid? ReferencedRecipeId { get; set; }

    public Guid? IngredientId { get; set; }

    public decimal Units { get; set; }

    public Guid UnitType { get; set; }
}