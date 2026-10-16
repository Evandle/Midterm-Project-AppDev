using ExamApp.Models;   // change ExamApp to your project name

namespace ExamApp.Data;

// One shared list of products. Home, Merch and Item all read from here,
// so you only ever edit your products in this one file.
public static class ProductCatalog
{
    public static readonly List<Product> All = new()
    {
        new() { Id = 1,  Name = "Chibi Acrylic Keychain",   Price = 10.32m, Category = "Keychains", IsBestSeller = true, ImagePath = "images/products/keychainKei1.jpg",
                Description = "A chibi character keychain with a clear acrylic finish and a metal ring. Small enough to clip on any bag." },

        new() { Id = 2,  Name = "Acrylic Stand Set",        Price = 25.07m, Category = "Standees",  IsBestSeller = true, ImagePath = "images/products/standie1.jpg",
                Description = "A set of clear acrylic stands that put your favorite characters on display, on a desk or a shelf." },

        new() { Id = 3,  Name = "Anniversary Goods Package", Price = 47.94m, Category = "Packages", IsBestSeller = true, ImagePath = "images/products/package1.jpg",
                Description = "A boxed bundle of keychains, cards and extras, packed together as a collector's set." },

        new() { Id = 4,  Name = "Trading Card Set (Random)", Price = 1.84m, Category = "Cards",     IsBestSeller = true, ImagePath = "images/products/card1.jpg",
                Description = "Collectible character cards. The designs are random, so you never know which ones you will get." },

        new() { Id = 5,  Name = "Kei Plush Doll",         Price = 28.76m, Category = "Plush",     IsBestSeller = true, IsNew = true, IsSoldOut = true, ImagePath = "images/products/fumo1.webp",
                Description = "A soft sitting plush of a chibi character, sized to sit on your desk or bed." },

        new() { Id = 6,  Name = "Charm Strap Keychain",     Price = 11.06m, Category = "Keychains", IsBestSeller = true, IsNew = true, ImagePath = "images/products/keychainToki1.jpg",
                Description = "A keychain with a strap and a blue tag charm. Easy to clip on a bag or a phone." },

        new() { Id = 7,  Name = "Embroidered Cape Jacket",  Price = 39.99m, Category = "Apparel",   IsBestSeller = true, IsNew = true, ImagePath = "images/products/aparel1.jpg",
                Description = "A navy cape-style jacket with gold trim details. A statement piece for cosplay or everyday wear." },

        new() { Id = 8,  Name = "Round Badge Pin Set",      Price = 12.50m, Category = "Pins",      IsBestSeller = true, IsNew = true, ImagePath = "images/products/pin1.jpg",
                Description = "A set of round pin badges with different character designs, ready for a bag or a jacket." },

        new() { Id = 9,  Name = "Sleep Mask Set",           Price = 15.00m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/mask1.jpg",
                Description = "A soft eye mask in a gift box, packed with matching cards." },

        new() { Id = 10, Name = "ID Card Lanyard Set",      Price = 13.25m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/id1.jpg",
                Description = "A lanyard with a matching ID card holder, for badges, keys and passes." },

        new() { Id = 11, Name = "Illustrated Pouch",        Price = 5.16m,  Category = "Lifestyle", IsNew = true, ImagePath = "images/products/sticker1.jpg",
                Description = "A flat pouch printed with a group illustration and a pull tab. Good for cards, cables and small items." },

        new() { Id = 12, Name = "Black Backpack",           Price = 22.00m, Category = "Lifestyle", IsNew = true, ImagePath = "images/products/bag1.jpg",
                Description = "A black backpack with teal accents and plenty of room for daily use." },
    };

    public static List<Product> GetBestSellers() => All.Where(p => p.IsBestSeller).ToList();

    public static List<Product> GetNewArrivals() => All.Where(p => p.IsNew).ToList();

    public static Product? GetById(int id) => All.FirstOrDefault(p => p.Id == id);
}