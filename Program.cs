using System;

namespace RPGShhopSystem
{
    class Program
    {
        static void Main()
        {
            Player player1 =
                new Player("Reinan", 500);

            ShopItem shopItem1 =
                new ShopItem("Iron Sword", 100);
            ShopItem shopItem2 =
                new ShopItem("Health Potion", 25);
            ShopItem shopItem3 =
                new ShopItem("Magic Ring", 500);

            Shop shop1 = new Shop();

            shop1.AddItem(shopItem1);
            shop1.AddItem(shopItem2);
            shop1.AddItem(shopItem3);

            shop1.DisplayItems();

            var items = new List<ShopItem>();
            Inventory inventory1 = new Inventory(player1, items);

            player1.BuyItem(shopItem1, inventory1);

            Console.WriteLine($"{player1.Name} purchased {shopItem1.ItemName} for {shopItem1.Price} gold.");
            Console.WriteLine($"Current Gold: {player1.Gold}");

            inventory1.DisplayInventory();
        }
    }
}