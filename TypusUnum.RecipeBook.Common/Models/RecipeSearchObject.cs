namespace TypusUnum.RecipeBook.Common.Models;

public class RecipeSearchObject
{
    public RecipeSearchObject()
    {
        this.RecipeName = String.Empty;
        this.Ingredients = new List<Guid>();
        this.DietaryRestrictions = new List<Guid>();
        this.Limit = 10;
        this.Offset = 0;
        this.AccountId = null;
    }
    
    public int Limit { get; set; }

    public int Offset { get; set; }

    public Guid? AccountId { get; set; }

    public string RecipeName { get; set; }

    public List<Guid> Ingredients { get; set; }

    public List<Guid> DietaryRestrictions { get; set; }
}