namespace Lab1ADayAtTheRaces
{
    public class Bet
    {
        public Bet(uint amt = 0, Dog dog = null)
        {
            Amount = amt;
            Dog = dog;
        }

        public uint Amount { get; set; }
        public Dog Dog { get; set; }

        public uint PayOut(Dog winningDog)
        {
            return (Dog == winningDog) ? 2 * Amount : 0;
        }
    }
}