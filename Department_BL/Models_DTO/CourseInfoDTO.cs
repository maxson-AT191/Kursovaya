using Department_Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_BL.Models_DTO
{
    public class CourseInfoDTO
    {
        public List<GroupDTO> Groups { get; set; }

        private int lecturerHours;
        public int LectureHours 
        {
            get => lecturerHours;
            set
            {
                if (value > 0)
                    lecturerHours = value;
            }
        }

        private int practiceHours;
        public int PracticeHours 
        {
            get => practiceHours;
            set
            {
                if (value > 0)
                    practiceHours = value;
            }
        }

        private int laboratoryHours;
        public int LaboratoryHours 
        {
            get => laboratoryHours;
            set
            {
                if (value > 0)
                    laboratoryHours = value;
            }
        }

        public CourseInfoDTO()
        {
            Groups = null;
            LectureHours = -1;
            PracticeHours = -1;
            LaboratoryHours = -1;
        }

        public CourseInfoDTO(CourseInfo info)//принимает из базы данных часы
        {
            Groups = new List<GroupDTO>();
            foreach (var it in info.Groups)
                Groups.Add(new GroupDTO(it));

            LectureHours = info.Hours[0];
            PracticeHours = info.Hours[1];
            LaboratoryHours = info.Hours[2];
        }

        public CourseInfo ToDLA()
        {
            List<Group> tmp = new List<Group>();
            foreach(var it in Groups)
                tmp.Add(it.ToDLA());

            int[] hours = new int[3];
            hours[0] = LectureHours;
            hours[1] = PracticeHours;
            hours[2] = LectureHours;

            CourseInfo info = new CourseInfo
            {
                Groups = tmp.ToArray(),
                Hours = hours
            };

            return info;
        }
    }
}
