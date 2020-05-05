using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.view;

namespace WindowsFormsApp2.presenter
{
    public class SecondPresenter : ISecondPresenter
    {
        IChangeView changeView;

       public SecondPresenter(IChangeView change)
        {
            this.changeView = change;
        }

        public  void Run()
        {
            changeView.Show();
        }
    }
}
