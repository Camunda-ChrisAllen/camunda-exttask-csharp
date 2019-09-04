using System;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace testWorker

{
    [ExternalTaskTopic("credit-check")]
    class CreditCheckWorker : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine($"...checking for existing credit...");
        }
    }
}