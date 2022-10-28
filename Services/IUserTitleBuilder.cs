// ----------------------------------------------------------------------------------
// <copyright company="Exesoft Inc.">
//	This code was generated by Instant Web API code automation software (https://www.InstantWebAPI.com)
//	Copyright Exesoft Inc. © 2019.  All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TenantAPI.Models;

namespace TenantAPI.Services {
    
    
    public interface IUserTitleBuilder {
        
        Task<IQueryable<UserTitleModel>> GetUserTitles();
        
        IList<ExpandoObject> GetDisplayModels(List<string> propNames);
        
        Task<BuilderResponse> GetUserTitle_ByTitleId(int titleId);
        
        Task<BuilderResponse> AddUserTitle(UserTitleModel model);
        
        Task<BuilderResponse> UpdateUserTitle(UserTitleModel model);
        
        Task<BuilderResponse> DeleteUserTitle(int titleId);
    }
}

