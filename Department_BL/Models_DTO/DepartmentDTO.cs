using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class DepartmentDTO
    {
        string name;
        public string Name 
        {
            get => name;
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    name = ti.ToTitleCase(value);
                }
            }
        }

        private string head;
        public string Head
        {
            get => head;
            set
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                head = ti.ToTitleCase(value);
            }
        }
        public List<CourseDTO> Courses { get; set; }
        public StaffDTO Staff { get; set; }
        public string Password { get; set; }

        public DepartmentDTO()
        {
            Courses = new List<CourseDTO>();
            Staff = new StaffDTO();
        }

        public DepartmentDTO(Department department)//передаем обьекты из базы данных и делаем обьект с которым мы будем работать в програмпе присваемаем имя главу 
        {
            Courses = new List<CourseDTO>();
            Staff = new StaffDTO();

            foreach (var it in department.Cources)
                Courses.Add(new CourseDTO(it));

            Name = department.Name;
            Head = department.Head;
            Staff = new StaffDTO(department.DepartureStaff);
            Password = department.Password;
        }

        public void AddCourse(CourseDTO course)//если не существует добавляяем курс
        {
            if (ContainsCourse(course.Code))
                return;

            Courses.Add(course);
        }

        private bool ContainsCourse(string code)
        {
            foreach (var it in Courses)
                if (it.Code == code)
                    return true;
            return false;
        }

        public Department ToDLA()
        {
            List<Course> tmp = new List<Course>();//копирует все поля нашей реалтизации обратно в базу данных 
            foreach (var it in Courses)
                tmp.Add(it.ToDLA());

            Department department = new Department
            {
                Head = Head,
                DepartureStaff = Staff.ToDLA(),
                Cources = tmp.ToArray(),
                Name = Name,
                Password = Password
            };

            return department;
        }
    }
}
