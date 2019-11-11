using System.Runtime.Serialization;

namespace BasicSoapWebServices.DataContracts
{
    [DataContract]
    public class MathOperation
    {
        [DataMember]
        public decimal Number1 { get; set; }

        [DataMember]
        public decimal Number2 { get; set; }
    }
}