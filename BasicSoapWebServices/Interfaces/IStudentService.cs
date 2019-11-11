using BasicSoapWebServices.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BasicSoapWebServices.Interfaces
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        IEnumerable<Estudiantes> FindAll();

        [OperationContract]
        Estudiantes FindById(Guid id);

        [OperationContract]
        Estudiantes Save(string name, string lastName);

        [OperationContract]
        Estudiantes Update(Guid id, string name, string lastName);

        [OperationContract]
        void Delete(Guid id);
    }
}