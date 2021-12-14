using Otus_HW4.IO;

namespace Otus_HW4
{
    public class GameStarter
    {
        private readonly IDataConsole _dataConsole;
        private readonly ISecretValue _secretValue;

        public GameStarter(IDataConsole dataConsole, ISecretValue secretValue)
        {
            this._dataConsole = dataConsole;
            this._secretValue = secretValue;
        }
        public void Execute()
        {
            this._dataConsole.Write("Добро пожаловать в игру - !!!Угадай число!!!\n");
            this.ReadGameSettings(out int tryAmount, out int startOfRange, out int endOfRange, out int secretValue);
            this.Start(tryAmount, startOfRange, endOfRange, secretValue); 
        }

        private void ReadGameSettings(out int tryAmount, out int startOfRange, out int endOfRange, out int secretValue)
        {

            this._dataConsole.Write("Введите число попыток");
            tryAmount = this._dataConsole.Read();

            this._dataConsole.Write("Введите начало диапазона");
            startOfRange = this._dataConsole.Read();

            this._dataConsole.Write("Введите конец диапазона");
            endOfRange = this._dataConsole.Read();

            secretValue = this._secretValue.GetSecretValue(startOfRange, endOfRange);
        }

        public void Start(int tryAmount, int startOfRange, int endOfRange, int secretValue)
        {
            bool isSuccess = false;

            Console.Clear();
            while (tryAmount > 0)
            {
                this._dataConsole.Write($"Количество попыток: {tryAmount}");
                this._dataConsole.Write($"Введите число в диапазоне от {startOfRange} до {endOfRange}");
                int newUserValue = _dataConsole.Read();

                    if (newUserValue == secretValue)
                    {
                        isSuccess = true;
                        break;
                    }
                    else
                    {
                        if (newUserValue > secretValue)
                            this._dataConsole.Write($"Не угадали! Загаданное число меньше.\r\n");
                        else
                            this._dataConsole.Write($"Не угадали! Загаданное число больше.\r\n");
                    }
                tryAmount--;
            }

            if (isSuccess)
            {
                _dataConsole.Clear();
                _dataConsole.Write("Вы победили!\r\n");
                Console.ReadKey();
            }
            else
            {
                _dataConsole.Clear();
                _dataConsole.Write($"Вы проиграли! Число было - {secretValue}.\r\n");
                Console.ReadKey();
            }
        }



    }
}
