using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionLib
{
    public class InstitutionEduc
    {
        private Dictionary<string, List<Student>> allGroups_ = new Dictionary<string, List<Student>>();

        


        public List<Student> studentGroupRequest(string groupName)
        {
           
            List<Student> studentGroup = new List<Student>();
            foreach (string group in allGroups_.Keys)
            {
                if (group == groupName)
                {
                    studentGroup = allGroups_[group];
                }
            }
            return studentGroup;
        }
    }
}
