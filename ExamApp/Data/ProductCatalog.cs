using ExamApp.Models;   // change ExamApp to your project name

namespace ExamApp.Data;

// One shared list of products. Home, Merch and Item all read from here,
// so you only ever edit your products in this one file.
public static class ProductCatalog
{
    public static readonly List<Product> All = new()
    {
        new() { Id = 1,  Name = "Mascot Acrylic Keychain",      Price = 10.32m, Category = "Keychains", IsBestSeller = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 2,  Name = "Mini Diorama Acrylic Stand",   Price = 25.07m, Category = "Standees",  IsBestSeller = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 3,  Name = "Anniversary Goods Package",    Price = 47.94m, Category = "Packages",  IsBestSeller = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 4,  Name = "Trading Card Set (Random)",    Price = 1.84m,  Category = "Cards",     IsBestSeller = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 5,  Name = "Chibi Figural Pillow",         Price = 28.76m, Category = "Plush",     IsBestSeller = true, IsNew = true, IsSoldOut = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 6,  Name = "Strap Keyring",                Price = 11.06m, Category = "Keychains", IsBestSeller = true, IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 7,  Name = "Logo Hoodie",                  Price = 39.99m, Category = "Apparel",   IsBestSeller = true, IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 8,  Name = "Enamel Pin Set",               Price = 12.50m, Category = "Pins",      IsBestSeller = true, IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 9,  Name = "Canvas Tote Bag",              Price = 15.00m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 10, Name = "Ceramic Mug",                  Price = 13.25m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 11, Name = "Holographic Sticker Pack",     Price = 5.16m,  Category = "Stickers",  IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
        new() { Id = 12, Name = "Desk Mat",                     Price = 22.00m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/keychainKei1.jpg" },
    };

    public static List<Product> GetBestSellers() => All.Where(p => p.IsBestSeller).ToList();

    public static List<Product> GetNewArrivals() => All.Where(p => p.IsNew).ToList();

    public static Product? GetById(int id) => All.FirstOrDefault(p => p.Id == id);
}
