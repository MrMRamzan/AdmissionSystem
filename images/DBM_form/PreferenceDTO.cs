using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBM_form
{
    class PreferenceDTO
    {
        public string category { get; set; }
        public string department { get; set; }
        public string stdEmail { get; set; }
        public int ARN { get; set; }


        /*
         Override the equals method for object comparision
        */
        public override bool Equals(object o)
        {
            if (o == null || o.GetType() != typeof(PreferenceDTO))
                return false;
            PreferenceDTO ca = (PreferenceDTO)o;
          return  ca.category.Equals(category) && ca.department.Equals(this.department)&& ca.stdEmail.Equals(this.stdEmail);
            
        }
        /*
         Override the getHash method for object comparision
        */
        public override int GetHashCode()
        {
          return stdEmail.GetHashCode();
            
        }



    }// class end 
}// form end 
