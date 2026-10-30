namespace RPGShhopSystem
{
    public class ShopItem
    {
        public string ItemName { get; set; }
        public int Price { get; set; }

        public ShopItem(string itemName, int price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}