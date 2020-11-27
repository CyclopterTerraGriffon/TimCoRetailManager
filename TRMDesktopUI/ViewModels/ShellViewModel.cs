using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVm;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVm = loginVM;
            ActivateItem(_loginVm);
        }
    }

}
