using System;
using System.Linq;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Main {

    [Route("api/companies")]
    public class CompaniesController : ControllerBase {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public CompaniesController(IRepositoryManager repository, ILoggerManager logger) {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCompanies() {
            var companies = _repository.Company.GetAllCompanies(trackChanges: false);
            var companiesDto = companies.Select(x => new CompanyDTO {
                Id = x.Id,
                Name = x.Name,
                FullAddress = string.Join(' ', x.Address, x.Country)
            });
            return Ok(companiesDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompany(Guid id) {
            var company = _repository.Company.GetCompany(id, trackChanges: false);
            if (company == null) {
                _logger.LogError($"Company with id: {id} doesn't exist in the database.");
                return NotFound();
            } else {
                var companyDto = new CompanyDTO {
                    Id = company.Id,
                    Name = company.Name,
                    FullAddress = string.Join(' ', company.Address, company.Country)
                };
                return Ok(companyDto);
            }
        }
    }

}