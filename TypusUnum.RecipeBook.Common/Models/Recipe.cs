namespace TypusUnum.RecipeBook.Common.Models;

public class Recipe
{
    public Recipe()
    {
        this.Ingredients = new List<RecipeIngredient>();
    }
    
    public Guid RecipeId { get; set; }

    public Guid? OriginalRecipeId { get; set; }

    public Guid AccountId { get; set; }

    public string RecipeName { get; set; }

    public string RecipeDescriptionJson { get; set; }

    public string RecipeHistoryJson { get; set; }

    public DateTime OriginallyCreatedTimestamp { get; set; }
    
    public Guid OriginallyCreatedBy { get; set; }
    
    public DateTime CreatedTimeStamp { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedTimeStamp { get; set; }

    public Guid UpdatedBy { get; set; }

    public List<RecipeIngredient> Ingredients { get; set; }
}