using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.Models;
using TurnKey.Model.ViewModels;

namespace TurnKey.BAL.Interface
{
    public interface IProspectRegisteredBAL
    {
        Task<List<ProspectRegistered>> GetProspectRegisteredList(string eventPasscode);
        Task<List<EventProspectDetails>> GetEventDetails(string eventPasscode);
        Task<bool> DeleteProspects(string Id);

        Task<List<TemplateBucket>> GetTemplateBucket();
        Task<List<Template>> GetTemplateData(int bucketId);

        Task<List<TemplateContent>> TemplateContent(int templateId);
    }
}
