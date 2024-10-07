
namespace TypusUnum.RecipeBook.API;

using Microsoft.OpenApi.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    #region Private Properties

    private readonly string myAllowSpecificOrigins = "_myAllowSpecificOrigins";
    
    private IConfiguration _configuration { get; }

    #endregion

    #region Public Methods

    /// <summary>
    /// Configures the Services for the application
    /// </summary>
    /// <param name="services">An instance of the <see cref="IServiceCollection"/> interface.</param>
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure Swagger
        services.AddSwaggerGen(
            c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Recipe Book",
                        Version = "v1",
                        Description = "Recipe Book API"
                    });
            });

        // CORS
        services.AddCors(
            options =>
            {
                options.AddPolicy(
                    this.myAllowSpecificOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

        services.AddHttpContextAccessor();
            
        services.AddControllers();
    }

    /// <summary>
    /// Configures for each request
    /// </summary>
    /// <param name="app">An instance of the <see cref="IApplicationBuilder"/> interface.</param>
    /// <param name="env">An instance of the <see cref="IWebHostEnvironment"/> interface.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();

        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
        // specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sentinel Security Service API v1");
            c.RoutePrefix = string.Empty;
        });
        
        app.UseCors(this.myAllowSpecificOrigins);
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    #endregion
}