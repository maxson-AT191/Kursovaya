using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class CourseDTO
    {
        private string name;
        public string Name 
        {
            get => name;
            set
            {
                if(value != null)
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;//проверка имени которое поступает
                    name = ti.ToTitleCase(value);
                }
            }
        }
        public string Code { get; set; }

        public CourseInfoDTO Info { get; set; }
        public StaffDTO Staff { get; set; }

        public CourseDTO()
        {
            Name = null;
            Code = null;
            Info = new CourseInfoDTO();
            Staff = new StaffDTO();
        }

        public CourseDTO(Course course)
        {
            Name = course.Name;
            Code = course.Code;
            Info = new CourseInfoDTO(course.Info);
            Staff = new StaffDTO(course.Staff);
        }

        public Course ToDLA()//конвертирует обратно в базу данніх
        {
            Course course = new Course
            {
                Code = Code,
                Name = Name,
                Info = Info.ToDLA(),
                Staff = Staff.ToDLA()
            };
            return course;
        }

    }
}
