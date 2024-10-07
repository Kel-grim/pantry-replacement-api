namespace TypusUnum.RecipeBook.Common.Models;

public class DietaryRestrictionIngredient
{
    public Guid DietaryRestrictionId { get; set; }

    public Guid IngredientId { get; set; }

    public bool IsRestricted { get; set; }

    public string DeitaryRestrictionIngredientNotesJson { get; set; }
}