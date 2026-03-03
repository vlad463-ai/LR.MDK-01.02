using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionLib
{
    public class InstitutionEduc
    {
        public Dictionary<string, List<Student>> allGroups_ = new Dictionary<string, List<Student>>();

        public List<Student> StudentGroupRequest(string groupName)
        {
            List<Student> studentGroup = new List<Student>();
            if (allGroups_.ContainsKey(groupName))
            {
                studentGroup = allGroups_[groupName];
                return studentGroup;
            }
            else
            {
                return null;
            }
               
               
            
            
            
        }   

    }
}
