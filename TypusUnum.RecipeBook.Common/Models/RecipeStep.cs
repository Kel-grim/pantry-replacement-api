namespace TypusUnum.RecipeBook.Common.Models;

public class RecipeStep
{
    public RecipeStep()
    {
        this.RecipeIngredients = new List<RecipeIngredient>();
    }
    
    public Guid RecipeStepId { get; set; }

    public Guid RecipeId { get; set; }

    public int StepPosition { get; set; }

    public string StepName { get; set; }

    public string StepDescriptionJson { get; set; }

    public List<RecipeIngredient> RecipeIngredients { get; set; }
}