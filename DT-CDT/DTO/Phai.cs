using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    public class Phai
    {
        public Phai(int Phaiid, string PhaiTen)
        {
            this.Phaiid = Phaiid;
            this.PhaiTen = PhaiTen;
        }
        public Phai(DataRow row)
        {

            this.Phaiid = (int)row["Phaiid"];
            this.PhaiTen = row["PhaiTen"].ToString();
            
        }
        
        private int phaiid;

        public int Phaiid
        {
            get { return phaiid; }
            set { phaiid = value; }
        }
        private string phaiTen;

        public string PhaiTen
        {
            get { return phaiTen; }
            set { phaiTen = value; }
        }
    }
}

