using FluentApi.Apis;
using FluentApi.Enums;

namespace FluentApi
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var pussy = FluentPussy
                .CreatePussy(options => options.Status = WetStatus.Semenful)
                .FromOwner("Putin")
                .WithSemenAmount(500)
                .FromDick("Zelensky")
                .WithToy("Lukashenko")
                .Build();

            Console.WriteLine(pussy);
        }
    }
}