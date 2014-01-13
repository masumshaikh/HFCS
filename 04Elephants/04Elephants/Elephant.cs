using System.Windows.Forms;

namespace _04Elephants
{
    public class Elephant
    {
        public Elephant(string name, int earsize)
        {
            Name = name;
            EarSize = earsize;
        }

        public int EarSize { get; set; }
        public string Name { get; set; }

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " cm tall", Name + " says ...");
        }
    }
}