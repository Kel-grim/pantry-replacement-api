namespace TypusUnum.RecipeBook.Common.Models;

public class DietaryRestriction
{
    public Guid DietaryRestrictionId { get; set; }

    public string DietaryRestrictionName { get; set; }

    public string DietaryRestrictionDescriptionJson { get; set; }

    public bool IsPublic { get; set; }

    public bool IsPrivate { get; set; }

    public Guid? AccountId { get; set; }
}