﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_UngVien
    {
        public static void ThemUngVien(DTO_UngVien ungVien)
        {
            DAO_UngVien.ThemUngVien(ungVien);
        }
    }
}
