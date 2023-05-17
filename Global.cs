using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class Global
    {
        //Biến truyền để phân biệt quyền trong MainForm
        private static int GlobalRoleID;
        //Biến truyền để phân biệt quyền trong ca trực
        private static int GlobalWokerID;

        public static int GlobalRoleID1 { get => GlobalRoleID; set => GlobalRoleID = value; }
        public static int GlobalWokerID1 { get => GlobalWokerID; set => GlobalWokerID = value; }

        public static void SetGlobalRoleId(int RoleID)
        {
            GlobalRoleID1 = RoleID;
        }

        public static void SetGlobalWokerID(int WokerID)
        {
            GlobalWokerID1 = WokerID;
        }
    }
}
