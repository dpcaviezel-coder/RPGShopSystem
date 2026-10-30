namespace RPGShhopSystem
{
    public class Shop
    {
        List<ShopItem> items = new();

        public void AddItem(ShopItem item)
        {
            items.Add(item);
        }
    

    public void DisplayItems()
        {
            Console.WriteLine("\n===== Shop =====");
            foreach (ShopItem item in items)
            {
                Console.WriteLine($"{item.ItemName}");
            }
            Console.WriteLine("================\n");
        }
    }
}