using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestNserviceBusPersistenceIssue
{
    public class SagaData : ContainSagaData
    {
        public SagaData()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
