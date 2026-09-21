using AutoMapper;
using Quiz1.DTO;
using Quiz1.Model;

namespace Quiz1.Mappings
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap< createStudentDto, Student>();

            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));


            CreateMap<StudentDto, Student>()
                .ForMember(dest => dest.FirstName,
                opt => opt.MapFrom(src => src.FullName.Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)[0]))

                .ForMember(dest => dest.LastName,
                opt => opt.MapFrom(src => src.FullName.Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)[0]));

        }
    }
}