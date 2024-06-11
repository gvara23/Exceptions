namespace Exceptions
{
    internal class Program
    {
        public static void ThrowError()
        {
            throw new CustomException("Houston, we have a problem !");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowError();
            }
            catch (CustomException e) 
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Date: {e.ExceptionTime}");
            }

        }
    }
}
