namespace RPGShhopSystem
{
    public class Inventory
    {
        public Player Player { get; set; }

        public List<ShopItem> Items { get; set; }

        public Inventory(Player player, List<ShopItem> items)
        {
            Player = player;
            Items = items;
        }

        public void AddItem(ShopItem item)
        {
            Items.Add(item);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n===== Inventory =====");
            foreach (ShopItem item in Items)
            {
                Console.WriteLine($"{item.ItemName}");
            }
            Console.WriteLine("=====================\n");
        }
    }
}