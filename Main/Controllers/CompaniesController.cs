using System;
using System.Collections.Generic;
using AutoMapper;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Main {

    [Route("api/companies")]
    public class CompaniesController : ControllerBase {

        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repository;

        public CompaniesController(ILoggerManager logger, IMapper mapper, IRepositoryManager repository) {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetCompanies() {
            try {
                var companies = _repository.Company.GetAllCompanies(trackChanges: false);
                var companiesDto = _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyDTO>>(companies);
                return Ok(companiesDto);
            } catch (Exception ex) {
                _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

    }

}