namespace TypusUnum.RecipeBook.Common.Models;

public class ServiceResult<T>
{
    public ServiceResult()
    {
        this.Messages = new List<Message>();
        this.IsSuccessful = false;
        this.IsValid = false;
    }

    #region Public Properties

    public bool IsValid { get; set; }

    public bool IsSuccessful { get; set; }

    public T Object { get; set; }

    public List<Message> Messages { get; set; }

    #endregion
}