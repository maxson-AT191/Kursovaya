using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class DepartmentsDbDTO
    {
        public List<DepartmentDTO> Departments { get; set; }

        public DepartmentsDbDTO()
        {
            Departments = new List<DepartmentDTO>();//конструктор
        }

        public DepartmentsDbDTO(DepartmentsDb db)//хранит список кафедр 
        {
            Departments = new List<DepartmentDTO>();

            foreach (var it in db.Departments)//копирует кафедры 
                if (!Departments.Contains(new DepartmentDTO(it)))
                    Departments.Add(new DepartmentDTO(it));
        }

        public DepartmentsDb ToDLA()
        {
            List<Department> departments = new List<Department>();
            foreach (var it in Departments)
                departments.Add(it.ToDLA());

            DepartmentsDb db = new DepartmentsDb { Departments = departments.ToArray() };
            return db;
        }

    }
}
