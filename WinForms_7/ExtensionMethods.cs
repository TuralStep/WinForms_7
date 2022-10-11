using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_7;


public static class ExtensionMethods
{

    public static FontStyle AddFontStyle(this FontStyle fs, FontStyle fs2)
    {

        FontStyle result = fs | fs2;
        return result;
    }

}
