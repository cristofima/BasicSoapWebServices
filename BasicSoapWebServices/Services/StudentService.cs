using BasicSoapWebServices.Interfaces;
using BasicSoapWebServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicSoapWebServices.Services
{
    public class StudentService : IStudentService
    {
        private readonly PruebasContext pruebasContext;

        public StudentService(PruebasContext _pruebasContext)
        {
            this.pruebasContext = _pruebasContext;
        }

        public void Delete(Guid id)
        {
            var student = this.pruebasContext.Estudiantes.Find(id);
            if (student == null)
            {
                throw new Exception($"Student with id '{id}' not found");
            }

            this.pruebasContext.Remove(student);
            this.pruebasContext.SaveChanges();
        }

        public IEnumerable<Estudiantes> FindAll()
        {
            return this.pruebasContext.Estudiantes.ToList();
        }

        public Estudiantes FindById(Guid id)
        {
            var student = this.pruebasContext.Estudiantes.Find(id);
            if (student == null)
            {
                throw new Exception($"Student with id '{id}' not found");
            }

            return student;
        }

        public Estudiantes Save(string name, string lastName)
        {
            var student = new Estudiantes
            {
                Nombres = name,
                Apellidos = lastName
            };

            this.pruebasContext.Add(student);
            this.pruebasContext.SaveChanges();

            return student;
        }

        public Estudiantes Update(Guid id, string name, string lastName)
        {
            var student = this.pruebasContext.Estudiantes.Find(id);
            if (student == null)
            {
                throw new Exception($"Student with id '{id}' not found");
            }

            student.Nombres = name;
            student.Apellidos = lastName;

            this.pruebasContext.Update(student);
            this.pruebasContext.SaveChanges();

            return student;
        }
    }
}