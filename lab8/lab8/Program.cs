using System;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            Task<string> server1Task = SimulateServerRequest("Сервер 1", 2000);
            Task<string> server2Task = SimulateServerRequest("Сервер 2", 3000);
            Task<string> server3Task = SimulateServerRequest("Сервер 3", 1000);

            Task<string> completedTask = await Task.WhenAny(server1Task, server2Task, server3Task);

            Console.WriteLine(await completedTask);
            Console.WriteLine("Запит завершено.");
        }

        static async Task<string> SimulateServerRequest(string serverName, int delay)
        {
            await Task.Delay(delay);
            return $"{serverName} відповів через {delay} мс";
        }
    }
}