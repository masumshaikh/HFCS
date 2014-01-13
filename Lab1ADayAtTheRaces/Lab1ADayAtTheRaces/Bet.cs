namespace Lab1ADayAtTheRaces
{
    public class Bet
    {
        public Bet(uint amt = 0, int dog = 0)
        {
            Amount = amt;
            Dog = dog;
        }

        public uint Amount { get; set; }
        public int Dog { get; set; }

        public uint PayOut(int winningDog)
        {
            return (Dog == winningDog) ? 2 * Amount : 0;
        }
    }
}