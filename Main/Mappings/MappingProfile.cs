using AutoMapper;
using Entities;

namespace Main {

    public class MappingProfile : Profile {

        public MappingProfile() {
            CreateMap<Company, CompanyDTO>().ForMember(c => c.FullAddress, opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            CreateMap<Employee, EmployeeDto>();
        }

    }

}