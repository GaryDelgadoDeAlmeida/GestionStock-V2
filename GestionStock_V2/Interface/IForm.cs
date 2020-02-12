using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock_V2.Interface
{
    interface IForm
    {
        void OpenForms(Object form);

        void enabledButtonEditOrList(bool etat, string type = null);
    }
}
