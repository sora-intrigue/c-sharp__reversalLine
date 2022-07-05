namespace line_reversal
{
    public class Program
    {
        static void Main(string[] args)
        {

            string fwd = Console.ReadLine(); // получение строки от пользователя
            string rvs = Reverse(fwd); // функция, которая переворачивает строку

            Console.WriteLine(rvs); // вывод перевернутой строки

        }

        private static string Reverse(string fwd) // функция для переворачивания строк
        {
            char[] carr = fwd.ToCharArray(); // массив равный строке(преобразована в массив), полученной от пользователя
            char temp; 
            for (int i = 0; i < carr.Length / 2; i++) // пока счетчик меньше половины длины массива
            {
                temp = carr[carr.Length - 1 - i]; // берем элемент массива минус счетчик
                carr[carr.Length - 1 - i] = carr[i]; // меняем местами элементы массива
                carr[i] = temp;
            }
            return new string(carr); // возвращает перевернутую строку

        }
    }
}