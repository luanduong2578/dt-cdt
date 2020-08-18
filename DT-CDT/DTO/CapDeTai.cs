using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public  class CapDeTai
    {
        public CapDeTai(int CapDTId, string CapDTTen)
        {
            this.CapDTId = CapDTId;
            this.CapDTTen = CapDTTen;
        }
                public CapDeTai(DataRow row)
        {

            this.CapDTId = (int)row["CapDTId"];
            this.CapDTTen = row["CapDTTen"].ToString();
            
        }
                private int capDTId;

                public int CapDTId
                {
                    get { return capDTId; }
                    set { capDTId = value; }
                }

                private string capDTTen;

                public string CapDTTen
                {
                    get { return capDTTen; }
                    set { capDTTen = value; }
                }

       
    }
}
