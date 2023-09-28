﻿using MinistryOfWarerResources.Models;

namespace MinistryOfWarerResources.Models
{
    public class DaawaModel
    {
        public int Id { get; set; }

        //الدعوى
        public string SelectDawa { get; set; } 
        
        //رقم الدعوى
        public string DawaNumber { get; set; } 

        //المدعي
        public string Name1 { get; set;}

        //المدعى عليه
        public string Name2 { get; set;}

        //موضوع الدعوى
        public string DawaSubject { get; set;}

        //نوع الدعوى
        public string DawaType { get; set;}

        //اسم التشكيل
        public string Office { get; set; }

        //المحكمة المختصة
        public string Court { get; set;}

        //رقم القرار البدائي
        public string Decision1Num { get;set;}

        //صورة القرار البدائي
        public string Decision1ImagePath { get;set;}

        public int AstanafNO { get; set; }


        public int TameezNO { get; set; }


        public int TashehNO { get; set; }
        public int qraraadaNO { get; set; }

        public string AkherALajraaat { get; set; }
        //الملاحظات
        public string Notes { get;set; }



        //تاريخ التحديث
        public DateTime LastUpdate { get; set; }




    }
}
