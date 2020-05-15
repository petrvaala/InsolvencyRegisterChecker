using System;
using InsolvencyRegisterCuzkServiceReference;
using PetrVala.InsolvencyRegisterChecker.ServiceLibrary;

namespace PetrVala.InsolvencyRegisterChecker.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var wrapper = new ServiceFullWrapper();

            //var request = new getIsirWsCuzkDataRequest {ic = "64651975", maxRelevanceVysledku = 2};
            var request = new getIsirWsCuzkDataRequest {ic = "27604977", maxRelevanceVysledku = 2};
            var resultTask = wrapper.GetIsirWsCuzkDataAsync(request);

            resultTask.Wait();

            var result = resultTask.Result;
            Console.WriteLine("Hello World!");
        }
    }
}