using NServiceBus;
using System;

namespace TestNServiceBusPersitenceIssue.Infrastructure
{
    public class TestSaga2 : Saga<SagaData2>
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<SagaData2> mapper)
        {
            throw new NotImplementedException();
        }
    }
}
