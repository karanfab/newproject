using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.DAL.Interface
{
    public interface IUserAccountDAL
    {
        /// <summary>
        /// Get All User Account List
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task<List<UserVM>> GetAllUser();

        /// <summary>
        /// Get All User Role
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task<List<Role>> UserRole();

        /// <summary>
        /// Create User Account
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int CreateUserAccount(SqlParameter[] prms);

        /// <summary>
        /// Get ById UserAccount
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<User> GetByIdUserAccount(Guid Id);

        /// <summary>
        /// Update User Account
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int UpdateUserAccount(SqlParameter[] prms);

        /// <summary>
        /// Delete User Account List
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<bool> DeleteUserAccount(Guid Id);
    }
}
