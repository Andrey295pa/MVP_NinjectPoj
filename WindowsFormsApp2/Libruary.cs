using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using WindowsFormsApp2.presenter;
using WindowsFormsApp2.view;

namespace WindowsFormsApp2 
{
    public class Libruary : NinjectModule
    {
        public override void Load()
        {
            // Bind<IUserRepository>().To<UserRepository>();
            Bind<IViewMessage>().To<Form1>();
            Bind<IMainPresenter>().To<MainPresenter>();
            Bind<IChangeView>().To<Form2>();
            Bind<ISecondPresenter>().To<SecondPresenter>();
        }
    }
}
