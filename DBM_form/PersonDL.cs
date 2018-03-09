using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DBM_form
{
    class PersonDL
    {
        public static ArrayList registerStd = new ArrayList();

        // add object in arraylist of PersonDTO
        public void addStd(PersonDTO obj)
        {
            registerStd.Add(obj);
           
        }

        // set ARN 
        public void setARNinperson(int key)
        {
            if (registerStd.Count > 0)
            {
                foreach(PersonDTO u in registerStd)
                {
                    if (u.ARN == 0)
                    {
                        u.ARN = key;
                    }
                }
            }
        }// fun end 

        public string getNameOfstd(int key)
        {
            foreach(PersonDTO u in registerStd)
            {
                if (u.ARN == key)
                {
                    return u.name + "," + u.email;
                }
            }
            return "";
        }
    }// clas end
} // form end
