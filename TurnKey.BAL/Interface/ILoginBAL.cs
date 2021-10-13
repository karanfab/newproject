using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnKey.Model.ViewModels;

namespace TurnKey.BAL.Interface
{
    public interface ILoginBAL
    {
        List<UserDetailVM> GetUserDetail(string userName, string password);

        List<MenuBar> GetUserPermissionMatrix(string userName);

    }
}
