namespace eKakauu.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ChocolateId { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateDate { get; set; }

        public Chocolate Chocolate { get; set; }
    }

}
