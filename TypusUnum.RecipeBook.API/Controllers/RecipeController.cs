using Microsoft.AspNetCore.Mvc;
using TypusUnum.RecipeBook.Common.Models;

namespace TypusUnum.RecipeBook.API.Controllers;

[Route("recipe")]
[Controller]
public class RecipeController : LoggingController
{
    #region Constructors

    public RecipeController()
    {
       
    }

    #endregion

    #region Private Properties


    
    #endregion

    #region Public Methods

    [HttpPost]
    public IActionResult Search([FromBody] RecipeSearchObject recipeSearchObject)
    {
        try
        {
            this._logger.Trace("Search Called.");
            return this.StatusCode(204);
        }
        catch (ArgumentNullException exception)
        {
            return this.StatusCode(400);
        }
        catch (ArgumentException exception)
        {
            return this.StatusCode(400);
        }
        catch (Exception e)
        {
            return this.StatusCode(500);
        }
    }

    #endregion
}