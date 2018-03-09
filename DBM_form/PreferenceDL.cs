using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DBM_form
{
    class PreferenceDL
    {

        static public ArrayList preferenceList = new ArrayList();

       static public  List<int> seats = new List<int>(){ 3,3,3};
       static public List<int> enrolled = new List<int>() {0,0,0 };
        
        //add objects of PreferenceDTO in arrayliat
        public bool addPreference(PreferenceDTO Obj)
        {
            
            if (preferenceList.Count == 0)
            {
                preferenceList.Add(Obj);
                return true;
            }
            else
            {
                // check if object is alredy there don't add in array list
                if (preferenceList.Contains(Obj))
                {
                    return false;
                }
                else
                {
                    preferenceList.Add(Obj);
               
                    return true;
                }

            }// else of main if
        }// add fun end

        // set ARN as unique key
        public void setARNinpreference(int key)
        {
            if (preferenceList.Count>0)
            {
                foreach(PreferenceDTO u in preferenceList)
                {
                    if (u.ARN == 0)
                    {
                        u.ARN = key;
                    }
                }
            }
        }// fun  setARN end


        /*
         retrun first preference of student if department of first 
         preference is already filled retrun null
         otherewise return department and category 
        */
        public string firstPreference(int arn)
        {
            foreach (PreferenceDTO u in preferenceList)
            {
                if (u.ARN == arn)
                {
                    // function Or text file to get depart name and category
                    // also manage seats and enrolled student
                    if (u.department== "Computer Science" && seats[0]>0)
                    {
                        enrolled[0] += 1;
                        seats[0] -= 1;
                        return "" + u.department+","+u.category;
                    }
                    else if(u.department== "Electrical Engineering" && seats[1]>0)
                    {
                        enrolled[1] += 1;
                        seats[1] -= 1;
                        return "" + u.department+","+u.category;
                    }
                    else if (u.department== "Civil Engineering" && seats[2]>0)
                    {
                        enrolled[2] += 1;
                        seats[2] -= 1;
                        return "" + u.department+","+u.category;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            return "";
        }
      }//class end 
}// form end
