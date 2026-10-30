namespace RPGShhopSystem
{
    public class Player
    {
        public string Name { get; set; }
        public int Gold { get; private set; }

        public Player(string name, int startingGold)
        {
            if (startingGold < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startingGold));
            }

            Name = name;
            Gold = startingGold;
        }

        public void SpendGold(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount > Gold)
            {
                throw new InvalidOperationException("The player does not have enough gold.");
            }

            Gold -= amount;
        }

        public void EarnGold(int amount)
        {
            Gold += amount;
        }

        public void BuyItem(
            ShopItem item,
            Inventory inventory)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (inventory == null)
            {
                throw new ArgumentNullException(nameof(inventory));
            }

            if (item.Price > Gold)
            {
                throw new InvalidOperationException("The player does not have enough gold to buy this item.");
            }

            SpendGold(item.Price);
            inventory.AddItem(item);
        }
    }
}