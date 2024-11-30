namespace eKakauu.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ChocolateId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Chocolate Chocolate { get; set; }
        public User User { get; set; }
    }

}
