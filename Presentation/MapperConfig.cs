using AutoMapper;
using Entity;
using Shared;

namespace Presentation
{
    public class MapperConfig
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeDTO, Employee>().ReverseMap().ForMember(c=>c.Department, act=>act.MapFrom(c=>c.Department.Name));
                c.CreateMap<DepartmentDTO, Department>().ReverseMap().ForMember(c => c.MainDepartment, act => act.MapFrom(c => c.MainDepartment.Name))
                                .ForMember(c => c.Boss, act => act.MapFrom(c => c.Boss.Fio));
            });
            return new Mapper(config);
        }
    }
}
