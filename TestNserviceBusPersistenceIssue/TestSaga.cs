using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestNserviceBusPersistenceIssue
{
    public class TestSaga : Saga<SagaData>
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<SagaData> mapper)
        {
            throw new NotImplementedException();
        }
    }
}
