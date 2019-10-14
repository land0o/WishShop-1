namespace WishShop
{
    public class DiscountWish : Wish
    {

        // : base(text) calls the constructor of wish
        public DiscountWish(string text) : base(text)
        {
            Price = 1_000;
            _successPercentage = 50;
        }

        public void IncreaseSuccessPercentage()
        {
            _successPercentage += 10;
            Price += 1_000;
        }
        public override bool MakeWish(User user)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("---Discount wish---");
            return base.MakeWish(user);
        }
    }
}