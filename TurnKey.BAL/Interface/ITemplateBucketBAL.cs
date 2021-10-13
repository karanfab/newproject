using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.BAL.Interface
{

    public interface ITemplateBucketBAL
    {
        /// <summary>
        /// Get All TemplateBucket List
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
    
        Task<List<TemplateBucket>> GetAllBucket();

       /// <summary>
       /// save
       /// </summary>
       /// <param name="template"></param>
       /// <returns></returns>
        int Save(TemplateBucket template);
       
       
        /// <summary>
        /// Update Bucket
        /// </summary>
        /// <param name="templateBucket"></param>
        /// <returns></returns>
        int UpdateBucket(TemplateBucket templateBucket);

        /// <summary>
        /// Delete
        /// </summary>
        /// 
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<int> DeleteBucket(int Id);

        Task<TemplateBucket> GetByIdEditBucket(int Id);
    }
}