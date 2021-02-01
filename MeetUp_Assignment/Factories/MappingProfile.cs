using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System.Linq;

namespace MeetUp_Assignment
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserModel , RegisterUser >();

            CreateMap<UserRegisterModel,RegisterUser> ();

            CreateMap<UserUpdateModel, RegisterUser> ();
        }
    }
}
