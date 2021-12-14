
using Otus_HW4.IO;

namespace Otus_HW4
{
    public class AnotherSecretValue : SecretValue
    {
        public override int GetSecretValue(int startOfRange, int endOfRange)
        {
            Random random = new Random();

            int coef = random.Next(1, 3);

            return random.Next(startOfRange * coef, endOfRange * coef);
        }
    }
}
