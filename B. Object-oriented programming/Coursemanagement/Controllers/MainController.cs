using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursemanagement.Views;

namespace Coursemanagement.Controllers
{
    internal class MainController
    {
        private readonly MainView _mainView;
        public MainController()
        {
            _mainView = new MainView();
        }
        public void ShowMenu()
        {
            _mainView.DisplayView();
        }
        public void Clear()
        {
            _mainView.Clearview();
        }
    }
}
  