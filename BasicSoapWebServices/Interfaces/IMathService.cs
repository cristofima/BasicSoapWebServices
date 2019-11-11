using BasicSoapWebServices.DataContracts;
using System.ServiceModel;

namespace BasicSoapWebServices.Interfaces
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        decimal Sum(MathOperation data);

        [OperationContract]
        decimal Subtraction(MathOperation data);

        [OperationContract]
        decimal Multiplication(MathOperation data);

        [OperationContract]
        decimal Division(MathOperation data);
    }
}