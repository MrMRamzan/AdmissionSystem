using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace DBM_form
{
    class AcademicDL
    {
        PreferenceDL objPreferenceDL = new PreferenceDL();
        /*
         Take toal marks of FSc and Obatined for Aggregate 
        */
        float totalFScMarks;
        float ObtainedFScMarks;

        /*
         Take toal marks of ECAT and Obatined for Aggregate 
        */
        float totalECATMarks = 0;
        float ObtainedECATMarks = 0;

        /*
          Array lists to store objects of AcademicDTO for TESTS and DEGREE
        */
        static public List<AcademicDTO> DegreeInfo = new List<AcademicDTO>();
        static public List<AcademicDTO> testInfo = new List<AcademicDTO>();

        /*
        Addin Array lists objects of AcademicDTO for DEGREE and compute aggregate
        */
        public void addDegrees(AcademicDTO Obj)
        {
            int size = DegreeInfo.Count;
            
            if (Obj.degreeName == "Inter")
            {
                totalFScMarks += Obj.totalMarks;
                ObtainedFScMarks += Obj.obtainMarks;

                if (ObtainedECATMarks > 0 && ObtainedFScMarks > 0)
                {
                    // look into only first 3 object peform caculations
                    Obj.Aggregate = (ObtainedFScMarks / totalFScMarks) * 70 + (ObtainedECATMarks / totalECATMarks) * 30;
                    ObtainedECATMarks = ObtainedFScMarks = totalFScMarks = totalECATMarks = 0;
                }
                else
                {
                    //
                }     
            }
            else if (Obj.degreeName == "ECAT")
            {
                totalECATMarks += Obj.totalMarks;
                ObtainedECATMarks += Obj.obtainMarks;
                if (ObtainedECATMarks > 0 && ObtainedFScMarks > 0)
                {
                    // look into only first 3 object peform caculations
                    Obj.Aggregate = (ObtainedFScMarks / totalFScMarks) * 70 + (ObtainedECATMarks / totalECATMarks) * 30;
                    ObtainedECATMarks = ObtainedFScMarks = totalFScMarks = totalECATMarks = 0;
                }
                else
                {
                    //
                }
            }
            else if (Obj.degreeName == "Matric")
            {
                if (ObtainedECATMarks > 0 && ObtainedFScMarks > 0)
                {
                    // look into only first 3 object peform caculations
                    Obj.Aggregate= (ObtainedFScMarks / totalFScMarks) * 70 + (ObtainedECATMarks / totalECATMarks) * 30;
                    ObtainedECATMarks = ObtainedFScMarks = totalFScMarks = totalECATMarks = 0;
                }
                else
                {
                    //
                }
            }// else if end 
            
            // finally add object in arraylist
            DegreeInfo.Add(Obj);

        }// add fun

        /*
         Add tests in arraylist 
        */
        public void addTest(AcademicDTO Obj)
        {
            testInfo.Add(Obj);
        }

        public void setARNinacademic(int key)
        {

            // add ARN in test information
            if (testInfo.Count > 0)
            {
                foreach(AcademicDTO u in testInfo)
                {
                   if(  u.ARN == 0)
                    {
                        u.ARN = key;
                    }
                    else
                    {
                        //do nothing
                    }
                }// for loop end
            }
            else
            {
                // do nothing
            }

            // add ARN in Degrees information
            if (DegreeInfo.Count > 0)
            {
                foreach (AcademicDTO u in DegreeInfo)
                {
                    if (u.ARN == 0)
                    {
                        u.ARN = key;
                    }
                    else
                    {
                        //do nothing
                    }
                }// for loop end
            }
            else
            {
                // do nothing
            }
        }// set function end here


        // meritlist function
        string preferDepart;

        public string sortFirstPreferenceDegree()
        {
           // sorting the list in desending order
           DegreeInfo= DegreeInfo.OrderByDescending(o => o.Aggregate).ToList();


            foreach(AcademicDTO u in DegreeInfo)
            {
                if (u.Aggregate != 0)
                {
                    //function to take first preference of student
                    // from the preference DL class
                    preferDepart = objPreferenceDL.firstPreference(u.ARN);

                    // check either there is capacity in the prefered depart
                    if (preferDepart != "")
                    {
                        return ""+u.ARN + "," + preferDepart +","+ u.Aggregate;
                    }
                    return "";
                }
            }
            return "";
        }


    }// class end 

}// form end
