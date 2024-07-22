namespace RandNumGen.Model
{
    public class Generator
    {
        private readonly Random random = new Random();
        public int vratCislo()
        {
            return random.Next(100);
        }
    }
}
