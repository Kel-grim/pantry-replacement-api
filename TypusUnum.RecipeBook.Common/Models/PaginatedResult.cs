namespace TypusUnum.RecipeBook.Common.Models;

public class PaginatedResult<T>
{
    public PaginatedResult()
    {
        this.Records = new List<T>();
    }
    
    public List<T> Records { get; set; }

    public int RecordCount { get; set; }
}