using System.ServiceModel;

namespace BasicSoapWebServices.Models
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