using System.Collections;

namespace Its.Onix.Erp.Businesses.Applications.OperationTest.Executors
{
    public interface IOperationExecutor
    {
        string ExecuteOperation(string oprName, Hashtable args);
    }
}