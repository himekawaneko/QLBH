﻿using DAL_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBH
{
    public class BUS_Khach
    {
        DAL_Khach dalKhach = new DAL_Khach();
        public DataTable getKhach()
        {
            return dalKhach.getKhach();
        }
        public bool InsertKhach(DTO_Khachhang khach)
        {
            return dalKhach.InsertKhach(khach);
        }
        public bool UpdateKhach(DTO_Khachhang khach)
        {
            return dalKhach.UpdateKhach(khach);
        }
        public bool DeleteKhach(string soDT)
        {
            return dalKhach.DeleteKhach(soDT);
        }
        public DataTable SearchKhach(string tenKhach)
        {
            return dalKhach.SearchKhach(tenKhach);
        }
    }
}
