using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    class ChungNhanDaoTao
    {
        public ChungNhanDaoTao(int CNDTId, string CNDTTen)
        {
            this.CNDTId = CNDTId;
            this.CNDTTen = CNDTTen;
        }
        public ChungNhanDaoTao(DataRow row)
        {

            this.CNDTId = (int)row["CNDTId"];
            this.CNDTTen = row["CNDTTen"].ToString();
            
        }

        private int cNDTId;

        public int CNDTId
        {
            get { return cNDTId; }
            set { cNDTId = value; }
        }

        private string cNDTTen;

        public string CNDTTen
        {
            get { return cNDTTen; }
            set { cNDTTen = value; }
        }


    }
}
