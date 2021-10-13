using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.BAL.Interface
{
 public interface ITemplateBAL
    {



        /// <summary>
        /// Get All Template List
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>

        Task<List<CreateModel>> GetAllTemplate();



        /// <summary>
        /// Delete Manage Template
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        /// 

        Task<int> DeleteMngTemplate(int Id);


        /// <summary>
        ///Get Bucket Type
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        ///
        Task<List<TemplateBucket>> GetTemplateBucket();
        /// <summary>
        /// create template
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>

        int SaveTemplate(CreateModel template);



        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        int UpdateTemplate(CreateModel template);

        /// <summary>
        /// edit template
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        Task<Templates> GetByIdEditTemplate(int Id);

    }

}
