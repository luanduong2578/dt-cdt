using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    class TinhTrangDeTai
    {
        public TinhTrangDeTai(int TTDTId, string TTDTTen)
        {
            this.TTDTId = TTDTId;
            this.TTDTTen = TTDTTen;
        }
        public TinhTrangDeTai(DataRow row)
        {

            this.TTDTId = (int)row["TTDTId"];
            this.TTDTTen = row["TTDTTen"].ToString();
            
        }

        private int tTDTId;

        public int TTDTId
        {
            get { return tTDTId; }
            set { tTDTId = value; }
        }

        private string tTDTTen;

        public string TTDTTen
        {
            get { return tTDTTen; }
            set { tTDTTen = value; }
        }

    }
}
