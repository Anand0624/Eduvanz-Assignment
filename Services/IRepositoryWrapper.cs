using System;
using System.Collections.Generic;
using System.Text;

namespace MeetUp.Services
{
    public interface IRepositoryWrapper 
    { 
        IUserRepository User { get; } 
        void Save(); 
    }
}
