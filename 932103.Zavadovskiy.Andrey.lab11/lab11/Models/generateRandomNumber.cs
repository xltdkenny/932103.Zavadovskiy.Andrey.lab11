namespace lab11.Models
{
    public class generateRandomNumber
    {
        public int firstNumber {  get; set; }
        public int secondNumber { get; set; }

        public generateRandomNumber()
        {
            var random = new Random(DateTime.Now.Millisecond);
            firstNumber = random.Next(10);
            secondNumber = random.Next(10);
        }
        public generateRandomNumber(int a, int b)
        {
            firstNumber = a;
            secondNumber = b;
        }
    }
}
