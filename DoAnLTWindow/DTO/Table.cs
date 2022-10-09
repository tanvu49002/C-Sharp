using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTWindow.DTO
{
    public class Table
    {
        public Table(int id, string ten, string trangthai)
        {
            ID = id;
            Name = ten;
            Status = trangthai;
        }

        public Table(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["TEN"].ToString();
            Status = row["TRANGTHAI"].ToString();
        }
        private string status;
    

        private string name;
      
        private int iD;

        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
