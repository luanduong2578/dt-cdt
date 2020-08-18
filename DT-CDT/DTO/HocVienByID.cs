using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_CDT.DTO
{
    class HocVienByID
    {
        public HocVienByID(int Id, string Phai, string Ngay, string Cd, string Kp, string Bv, string Hv)
        {
            this.Id = Id;
            this.Phai = Phai;
            this.Ngay = Ngay;
            this.Cd = Cd;
            this.Kp = Kp;
            this.Bv = Bv;
            this.Hv = Hv;
            

        }
         public HocVienByID(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Phai = row["Phai"].ToString();
            this.Ngay = row["Ngay"].ToString();
            this.Cd = row["Cd"].ToString();
            this.Kp = row["Kp"].ToString();
            this.Bv = row["Bv"].ToString();
            this.Hv = row["Hv"].ToString();
            
        }
         private string ngay;

         public string Ngay
         {
             get { return ngay; }
             set { ngay = value; }
         }
         private string hv;

         public string Hv
         {
             get { return hv; }
             set { hv = value; }
         }

        
        private string bv;

        public string Bv
        {
            get { return bv; }
            set { bv = value; }
        }
        private string kp;

        public string Kp
        {
            get { return kp; }
            set { kp = value; }
        }
        private string cd;

        public string Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        private string phai;

        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
