using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class LoaiDeTai
  {
        public LoaiDeTai(int LoaiDTId, string loaiDTTen)
        {
            this.LoaiDTId = LoaiDTId;
            this.loaiDTTen = loaiDTTen;
        }
        public LoaiDeTai(DataRow row)
        {

            this.LoaiDTId = (int)row["LoaiDTId"];
            this.loaiDTTen = row["loaiDTTen"].ToString();
            
        }

        private int loaiDTId;

        public int LoaiDTId
        {
            get { return loaiDTId; }
            set { loaiDTId = value; }
        }


        private string loaiDTTen;

        public string LoaiDTTen
        {
            get { return loaiDTTen; }
            set { loaiDTTen = value; }
        }

       
    }
}
