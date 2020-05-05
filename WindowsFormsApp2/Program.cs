using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.presenter;
using Ninject;
using Ninject.Modules;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var kernel = new StandardKernel(new Libruary());
            var presenter = kernel.Get<MainPresenter>();
            //kernel.Get<SecondPresenter>().Run();
            presenter.Run();
        }
    }
}
