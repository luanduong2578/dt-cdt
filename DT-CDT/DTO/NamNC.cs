using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    class NamNC
    {
        public NamNC(int Namid, int Namten)
        {
            this.Namid = Namid;
            this.Namten = Namten;
        }
        public NamNC(DataRow row)
        {

            this.Namid = (int)row["Namid"];
            this.Namten = (int)row["Namten"];

        }
        private int namid;

        public int Namid
        {
            get { return namid; }
            set { namid = value; }
        }
        private int namten;

        public int Namten
        {
            get { return namten; }
            set { namten = value; }
        }
    }
}
