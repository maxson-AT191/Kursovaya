using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class GroupDTO
    {
        private string specialty;
        public string Specialty 
        {
            get => specialty;
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    specialty = ti.ToTitleCase(value);
                }
            }
        }

        private int year;
        public int Year 
        {
            get => year;
            set
            {
                if (value > 0 && value < 8)//проверка года 
                    year = value;
            }
        }

        public GroupDTO()
        {
            Specialty = null;
            year = -1;
        }
        
        public GroupDTO(Department_Db.Models.Group group)
        {
            Specialty = group.Specialty;
            Year = group.Year;
        }

        public Department_Db.Models.Group ToDLA()//делает обьект дазы данных 
        {
            Department_Db.Models.Group group = new Department_Db.Models.Group
            {
                Specialty = Specialty,
                Year = Year
            };
            return group;
        }

        public override string ToString()
        {
            return $"{Specialty} {Year} year";//для выводы в форме 
        }
    }
}
