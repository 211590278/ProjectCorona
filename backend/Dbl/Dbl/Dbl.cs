using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbl
{
    public class Dbl
    {
        public String stringIsNotNull(String s)
        {
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

        //public String address(String city, String street, int numH)
        //{
        //    var fullAdress = "d";
        //    if (stringIsNotNull(city) != null)
        //        fullAdress = city + "@";
        //    else
        //        city = null;
        //    if (stringIsNotNull(street) != null)
        //        fullAdress = street + "@";
        //    else
        //        return null;
        //    if (numH > 0)
        //        fullAdress = numH + "@";
        //    else
        //        numH = -1;
        //    return fullAdress;

        //}
        //public DateTime dateOfBirth(DateTime dBirth)
        //{
        //    var bigDate = DateTime.Compare(dBirth, DateTime.Now);
        //    if (dBirth != null)
        //    {
        //        if (bigDate.Equals(dBirth))
        //            return dBirth;
        //    }
        //    return new DateTime();
        //}
        //public int phone(int phone1)
        //{
        //    if (phone1 > 8 && phone1 < 11)
        //    {
        //        return phone1;
        //    }
        //    return -1;
        //}
        //public int mobilePhone(int phone2)
        //{
        //    if (phone2 > 8 && phone2 < 11)
        //    {
        //        return phone2;
        //    }
        //    return -1;
        //}

        //public int idMember(int idIsraeli) {
        //    //{
        //    //    var id= idIsraeli.ToString();
        //    //    if(id == null)
        //    //        if (id.Length > 9  )
        //    //            return -1;
        //    //    if (id.Length < 9) {
        //    //        id = ("00000000" + id).Substring(8);  
        //    //    }
        //    //        return Array.from(id, Number).reduce((counter, digit, i) => {
        //    //            const step = digit * ((i % 2) + 1);
        //    //            return counter + (step > 9 ? step - 9 : step);
        //    //        }) % 10 == 0;

        //    //}
        //    return 1;
        // }

        public List<coronaDetails> allDetailsCoronaVirus()
        {
            var db = new coronaEntities();
            var detaiks = db.coronaDetails.Where(x => x.idMember >0).ToList();
            return detaiks;
        }
    

        public List<Member> allMembers()
        {
            var db = new coronaEntities();
            var members = db.Member.Where(x => x.firstName != null).ToList();
            return members;
        }

        public Member GetMemberById(int id)
        {
            var db = new coronaEntities();
            var member = db.Member.Where(x => x.idMember == id).Single<Member>();
            return member;
        }
        public coronaDetails addDetailsCorona(coronaDetails d)
        {
            var db = new coronaEntities();
            var dc = new coronaDetails();
            dc.idMember = d.idMember;
            dc.dateOfVaccination = d.dateOfVaccination;
            dc.madeVaccination = d.madeVaccination;
            dc.dateTrue = d.dateTrue;
            dc.dateRecovery = d.dateRecovery;
            db.coronaDetails.Add(dc);
            db.SaveChanges();
            var addDC = db.coronaDetails.Where(x => x.idMember == d.idMember).Single<coronaDetails>();
            return addDC;

        }

        public String deleteMember(int id)
        {
            var db = new coronaEntities();
            var member = db.Member.Where(x => x.idMember == id).Single<Member>();
            db.Member.Remove(member);
            db.SaveChanges();
            return "Member deletion was successful";
        }

        public String UpdateMember(Member m)
        {
            var db = new coronaEntities();
            var member = db.Member.Where(x => x.idMember == m.idMember).Single<Member>();
            member.idMember = m.idMember;
            member.firstName = m.firstName;
            member.lastName = m.lastName;
            member.address = m.address;
            member.dateOfBirth = m.dateOfBirth;
            member.phone = m.phone;
            member.mobilePhone = m.mobilePhone;
            db.Entry(m).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "update is successful";
        }

        //public void coronaDetails(coronaDetails d)
        //{
        //    var db = new coronaEntities();
        //    var n = new coronaDetails();
        //    n.idMember = d.idMember;
        //    n.dateOfVaccination = d.dateOfVaccination;
        //    n.madeVaccination = d.madeVaccination;
        //    n.dateTrue = d.dateTrue;
        //    n.dateRecovery = d.dateRecovery;
        //    db.coronaDetails.Add(n);
        //    db.SaveChanges();
        //}

        public Member addMember(Member m)
        {
            var db = new coronaEntities();
            var newM = new Member();
            newM.idMember = m.idMember;
            newM.firstName = m.firstName;
            newM.lastName = m.lastName;
            newM.address = m.address;
            newM.dateOfBirth = m.dateOfBirth;
            newM.phone = m.phone;
            newM.mobilePhone = m.mobilePhone;
            db.Member.Add(m);
            db.SaveChanges();
            var member = db.Member.Where(x => x.idMember == m.idMember).Single<Member>();

            return member;

        }




    }
}
