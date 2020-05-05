 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.view;

namespace WindowsFormsApp2.presenter
{
    public class MainPresenter : IMainPresenter
    {
         IViewMessage View;
        SecondPresenter SecondPresenter;

        public MainPresenter(IViewMessage viewMessage, SecondPresenter secondPresenter)
        {
            this.View = viewMessage;
            this.SecondPresenter = secondPresenter;
            this.View.Save += View_Save;
        }

        private void View_Save()
        {
            SecondPresenter.Run();
        }

        public void Run()
        {
            this.View.Show();
        }
    }
}
