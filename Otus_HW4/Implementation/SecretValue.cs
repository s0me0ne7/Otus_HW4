using Otus_HW4.IO;

namespace Otus_HW4
{
    public class SecretValue:ISecretValue
    {
        public virtual int GetSecretValue(int startOfRange, int endOfRange)
        {
            Random random = new Random();

            return random.Next(startOfRange, endOfRange);
        }
    }
}
