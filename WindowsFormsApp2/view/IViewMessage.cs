using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.view
{
    public interface IViewMessage: IView
    {
        string sms { set; get; }
        event Action Save;
    }
}
