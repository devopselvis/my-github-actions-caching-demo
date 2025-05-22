using System;
using Newtonsoft.Json;

namespace DemoCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Message = "Hello from the GitHub Actions Cache Demo!" };
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
    }
}
