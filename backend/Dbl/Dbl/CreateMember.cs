using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbl
{
    abstract class CreateMember
    {
        
        public String stringIsNotNull(String s)
        {
            var db = new coronaEntities();
            if (s != null)
            {
                return s;
            }
            else
            {
                return null;
            }
        }

        //public int intIsNotNull(int i)
        //{
        //    var db = new coronaEntities();
        //    if (i != null)
        //    {
        //        return i;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}


        //public String firstName(string fn)
        //{
        //    var db = new coronaEntities();
        //    if (fn != null)
        //    {
        //        return fn;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public String lastName(String ln)
        //{
        //    var db = new coronaEntities();
        //    if (ln != null)
        //    {
        //        return ln;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}

        public String address(String city, String street, int numH)
        {
            var fullAdress= "d";
            if (stringIsNotNull(city) != null)
                fullAdress= city +"@";
            else
                city=null;
            if (stringIsNotNull(street) != null)
                fullAdress = street + "@";
            else
                return null;
            if (numH > 0)
                fullAdress = numH + "@";
            else
                numH = -1;
            return fullAdress;

        }
        public DateTime dateOfBirth(DateTime dBirth)
        {
            var bigDate = DateTime.Compare(dBirth, DateTime.Now);
            if (dBirth != null)
            {
                if (bigDate.Equals(dBirth))
                    return dBirth;
            }
            return new DateTime();
        }
        public int phone(int phone1)
        {
            if (phone1 > 8 && phone1 < 11)
            {
                return phone1;
            }
            return -1;
        }
        public int mobilePhone(int phone2)
        {
            if (phone2 > 8 && phone2 < 11)
            {
                return phone2;
            }
            return -1;
        }
       



    }
}
