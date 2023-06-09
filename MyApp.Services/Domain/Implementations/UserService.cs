using System;
using System.Collections.Generic;
using System.Linq;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Implementations.Base;
using MyApp.Services.Domain.Interfaces;
using MyApp.Services.Domain.Interfaces.Base;

namespace MyApp.Services.Domain.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IDataAccess dataAccess) : base(dataAccess) { }

        /// <summary>
        /// Return users by active state
        /// </summary>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public IEnumerable<User> FilterByActive(bool isActive)
        {
           // ServiceBase<User> service = this;
           //return service.GetAll().Where(p => p.IsActive.Equals(isActive));
           return base.GetAll().Where(p => p.IsActive.Equals(isActive));
            // throw new NotImplementedException();
        }
    }
}
