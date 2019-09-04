using System;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace testWorker

{
    [ExternalTaskTopic("credit-charge")]
    class CreditChargeWorker : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine($"...charge credit card...");
        }
    }
}