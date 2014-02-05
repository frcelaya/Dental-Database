using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class TratReq
    {
        private String nombreTr, dispSerie;

        public String NombreTr
        {
            get { return nombreTr; }
            set { nombreTr = value; }
        }

        public String DispSerie
        {
            get { return dispSerie; }
            set { dispSerie = value; }
        }
    }
}
