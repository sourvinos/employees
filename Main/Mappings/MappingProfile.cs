using AutoMapper;
using Entities;

namespace Main {

    public class MappingProfile : Profile {

        public MappingProfile() {
            // Companies
            CreateMap<Company, CompanyDTO>().ForMember(c => c.FullAddress, opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            CreateMap<CompanyForCreationDto, Company>();
            // Employees
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeForCreationDto, Employee>();
            CreateMap<EmployeeForUpdateDto, Employee>();
        }

    }

}