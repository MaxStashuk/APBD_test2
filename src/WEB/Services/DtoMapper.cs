using WEB.Models;
using WEB.Models.DTOs;

namespace WEB.Services;

public static class DtoMapper
{
    public static StudentDTO ToDto(Student s)
    {
        return (s != null) ? new StudentDTO
            { 
                id = s.Id,
                firstName = s.FirstName,
                lastName = s.LastName,
                email = s.Email,
            }
            : null;
    }

    public static Student toModel(StudentDTO s)
    {   
        return (s != null) ? new Student()
            { 
                Id = s.id,
                FirstName = s.firstName,
                LastName = s.lastName,
                Email = s.email,
            }
            : null;
    }
}