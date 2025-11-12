namespace BaghaleMahal.Models
{
    public class Items
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public int CurrentPrice { get; set; }
        public int OldPrice { get; set; }
        public string[] Images { get; set; } = Array.Empty<string>();
        public ItemCategory Category { get; set; }
        public int Stock { get; set; }
        public string BoothId { get; set; } = string.Empty;
        public bool ShowSellerPhone { get; set; }
        public bool IsBanned { get; set; }
        public bool IsTempting { get; set; }
        public bool HasNationWideShipping { get; set; }
        public string[] ShippingLocations { get; set; } = Array.Empty<string>();

    }
    public enum ItemCategory
    {
        Electronics,
        Clothing,
        Food,
        Books,
        Other
    }
}
