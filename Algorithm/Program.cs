namespace Algorithm
{
    using System;
    using System.Threading;

    /// <summary>
    /// Application start.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Get array and sets user.
        /// </summary>
        /// <param name="args"> Args method.</param>
        private static void Main(string[] args)
        {
            User user1 = new User("Vasy", "Василий", true);

            User user2 = new User("bijg12354", "Александр", false);

            User user3 = new User("alsd245", "Евгений", true);

            User user4 = new User("Princ", "Рой", true);

            User[] userArr = new User[] { user1, user2, user3, user4 };

            for (int i = 0; i < userArr.Length; i++)
            {
                Console.WriteLine("Здравствуйте {0}", userArr[i].Name);
                if (!userArr[i].IsPremium)
                {
                    ShowAds();
                }
            }

            Console.WriteLine("для остановки нажмите Enter");

            Console.ReadKey();
        }

        /// <summary>
        /// Method show ads.
        /// </summary>
        private static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            //// Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            //// Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            //// Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}