namespace WebApplication1.Models
{
    public class ItemClient
    {
        public int ItemId { get; set; }
        public Item Item { get; set; } = new Item();
        public int ClientId { get; set; }
        public Client Client { get; set; } = new Client();
    }
}
