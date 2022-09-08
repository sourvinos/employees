using System;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Main {

    [Route("api/companies/{companyId}/employees")]
    public class EmployeesController : ControllerBase {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public EmployeesController(IRepositoryManager repository, ILoggerManager logger) {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid companyId) {
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null) {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
                return NotFound();
            }
            var employeesFromDb = _repository.Employee.GetEmployees(companyId, trackChanges: false);
            return Ok(employeesFromDb);
        }


        [HttpGet("{id}")]
        public IActionResult GetEmployeeForCompany(Guid companyId, Guid id) {
            var company = _repository.Company.GetCompany(companyId, trackChanges: false);
            if (company == null) {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the atabase.");
                return NotFound();
            }
            var employeeDb = _repository.Employee.GetEmployee(companyId, id, trackChanges:
            false);
            if (employeeDb == null) {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            return Ok(employeeDb);
        }
    }

}