using System;
using CamundaClient;

namespace testWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            CamundaEngineClient camunda = new CamundaEngineClient();
            camunda.Startup(); // Deploys all models and Start all found ExternalTask-Workers​
            Console.ReadLine(); // wait for ANY KEY​
            camunda.Shutdown();
        }
    }
}