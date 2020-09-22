using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PersonService:Service<Person>,IPersonService
    {
        private readonly IRepository<Person> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public PersonService(IRepository<Person> repository,IUnitOfWork unitOfWork):base(repository,unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
    }
}
