using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class LinhVucNghienCuu
    {
        public LinhVucNghienCuu(int LVNCId, string LVNCTen)
        {
            this.LVNCId = LVNCId;
            this.LVNCTen = LVNCTen;
        }
        public LinhVucNghienCuu(DataRow row)
        {

            this.LVNCId = (int)row["LVNCId"];
            this.LVNCTen = row["LVNCTen"].ToString();
            
        }
        private string lVNCTen;

        public string LVNCTen
        {
            get { return lVNCTen; }
            set { lVNCTen = value; }
        }
        private int lVNCId;

        public int LVNCId
        {
            get { return lVNCId; }
            set { lVNCId = value; }
        }
    }
}
