namespace Ch04Ex02PrimeFactorsLib
{
    public class PrimeFactors
    {
        public PrimeFactors()
        {
        }

        public static string GivePrimeFactors(int n)
        {
            string result = string.Empty;
            while (n % 2 == 0)
            {
                result += "2 ";
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2) 
            { 
                while (n % i == 0) 
                {
                    result += $"{i} ";
                    n /= i; 
                } 
            }
            if (n > 2)
                // output factors
                result += $"{n}";
            return result;
        }
    }
}
