using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class StaffDTO
    {
        private List<string> lecturers;
        public List<string> Lecturers 
        {
            get => lecturers;
            set
            {
                if (CheckFIO(value.ToArray()))
                    lecturers = ToTitleCase(value);
            }
        }

        private List<string> assistants;
        public List<string> Assistants 
        {
            get => assistants;
            set
            {
                if (CheckFIO(value.ToArray()))
                {
                    assistants = ToTitleCase(value);
                }
            }
        }

        public StaffDTO()
        {
            lecturers = new List<string>();
            assistants = new List<string>();
        }

        public StaffDTO(Staff staff)//проверяет повторяется ли
        {
            Lecturers = new List<string>();
            Assistants = new List<string>();

            foreach (var it in staff.Lecturers)
                if (!ContainsStaff(it))
                    Lecturers.Add(it);

            foreach (var it in staff.Assistants)
                if (!ContainsStaff(it))
                    Assistants.Add(it);
        }

        private bool CheckFIO(string[] fios)
        {
            foreach(var it in fios)
            {
                string[] words = it.Split(' ');
                if (words.Length != 3)
                    return false;
            }

            return true;
        }

        private bool CheckFIO(string fio)
        {
            string[] words = fio.Split(' ');
            if (words.Length != 3)
                return false;
            return true;
        }

        private List<string> ToTitleCase(List<string> fios)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            for (int i = 0; i < fios.Count; ++i)
                fios[i] = ti.ToTitleCase(fios[i]);

            return fios.ToList();
        }

        public bool ContainsStaff(string fio)
        {
            foreach (var it in Lecturers)
                if (it.Contains(fio))
                    return true;

            foreach (var it in Assistants)
                if (it.Contains(fio))
                    return true;

            return false;
        }

        public void AddLecturer(string fio)//проверяют корректности имени отчества
        {
            if (!CheckFIO(fio))
                return;

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            if (ContainsStaff(ti.ToTitleCase(fio)))
                return;

            Lecturers.Add(ti.ToTitleCase(fio));
        }

        public void AddAssistant(string fio)//проверяют корректности имени отчества
        {
            if (!CheckFIO(fio))
                return;

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            if (ContainsStaff(ti.ToTitleCase(fio)))
                return;

            Assistants.Add(ti.ToTitleCase(fio));
        }

        public Staff ToDLA()//преобразует наш обьект обратно в обьект базы данных
        {
            Staff staff = new Staff
            {
                Lecturers = Lecturers.ToArray(),
                Assistants = Assistants.ToArray()
            };
            return staff;
        }
    }
}
