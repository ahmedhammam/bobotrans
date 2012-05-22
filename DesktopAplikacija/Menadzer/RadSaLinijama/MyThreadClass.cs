using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Menadzer.RadSaLinijama
{
    class MyThreadClass
    {
        UredjivanjeLinije myFormControl1;
        public delegate void AddListItem();
        public AddListItem myDelegate;
        public MyThreadClass(UredjivanjeLinije myForm,AddListItem m)
        {
            myFormControl1 = myForm;
            myDelegate = m;
        }

        public void Run()
        {

            myFormControl1.Invoke(myFormControl1.myDelegate);
           // myFormControl1.Invoke(myFormControl1.myDelegate1);
        }
    }
}
