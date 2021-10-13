using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;


namespace TurnKey.DAL.Interface
{
    public interface ITemplateDAL
    {
        /// <summary>
        /// Get All Bucket List
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
      
        Task<List<TemplateBucket>> GetAllBucket();


        /// <summary>
        /// Save
        /// </summary>
        /// <param name="prms"></param>
        /// <returns></returns>
        /// 
        int Save(SqlParameter[] prms);
        /// <summary>
        /// update
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
       
        int UpdateBucket(SqlParameter[] prms);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>


        Task<int> DeleteBucket(SqlParameter[] prms);

        Task<TemplateBucket> GetByIdEditBucket(int Id);

    }
}
