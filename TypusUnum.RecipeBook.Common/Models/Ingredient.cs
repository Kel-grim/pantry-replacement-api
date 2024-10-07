namespace TypusUnum.RecipeBook.Common.Models;

public class Ingredient
{
    public Guid IngredientId { get; set; }

    public Guid OpenFoodId { get; set; }

    public string IngredientName { get; set; }

    public int CalorieCount { get; set; }

    public Guid ServingSizeUnitType { get; set; }

    public int ServingSizeUnits { get; set; }

    public decimal TotalFatPercentage { get; set; }

    public decimal TotalFatUnits { get; set; }

    public Guid TotalFatUnitType { get; set; }

    public decimal SaturatedFatPercentage { get; set; }

    public decimal SaturatedFatUnits { get; set; }

    public Guid SaturatedFatUnitType { get; set; }

    public decimal TransFatPercentage { get; set; }

    public decimal TransFatUnits { get; set; }

    public Guid TransFatUnitType { get; set; }

    public decimal CholesterolPercentage { get; set; }

    public decimal CholesterolUnits { get; set; }

    public Guid CholesterolUnitType { get; set; }

    public decimal SodiumPercentage { get; set; }

    public decimal SodiumUnits { get; set; }

    public Guid SodiumUnitType { get; set; }

    public decimal TotalCarbohydratePercentage { get; set; }

    public decimal TotalCarbohydrateUnits { get; set; }

    public Guid TotalCarbohydrateUnitType { get; set; }

    public decimal DietaryFiberPercentage { get; set; }

    public decimal DietaryFiberUnits { get; set; }

    public Guid DietaryFiberUnitType { get; set; }
    
    public decimal TotalSugarPercentage { get; set; }

    public decimal TotalSugarUnits { get; set; }

    public Guid TotalSugarUnitType { get; set; }

    public decimal IncludedAddedSugarPercentage { get; set; }

    public decimal IncludedAddedSugarUnits { get; set; }

    public Guid IncludedAddedSugarUnitType { get; set; }

    public decimal ProteinPercentage { get; set; }

    public decimal ProteinUnits { get; set; }

    public Guid ProteinUnitType { get; set; }
    
    public decimal VitaminDPercentage { get; set; }

    public decimal VitaminDUnits { get; set; }

    public Guid VitaminDUnitType { get; set; }
    
    public decimal CalciumPercentage { get; set; }

    public decimal CalciumUnits { get; set; }

    public Guid CalciumUnitType { get; set; }
    
    public decimal IronPercentage { get; set; }

    public decimal IronUnits { get; set; }

    public Guid IronUnitType { get; set; }
    
    public decimal PotassiumPercentage { get; set; }

    public decimal PotassiumUnits { get; set; }

    public Guid PotassiumUnitType { get; set; }
}