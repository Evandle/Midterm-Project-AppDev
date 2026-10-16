namespace ExamApp.Models;   // change ExamApp to your project name

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public string Category { get; set; } = "";
    public string ImagePath { get; set; } = "images/product-placeholder.svg";
    public bool IsSoldOut { get; set; }
    public bool IsBestSeller { get; set; }
    public bool IsNew { get; set; }

    // Ready-to-print price, for example "$28.76"
    public string PriceText => $"${Price:0.00}";
}
