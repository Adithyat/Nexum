using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class People
    {

        public static void DeletePeopleList(List<int> IDs)
        {
            foreach (int id in IDs)
            {
                PeopleDL.DeletePerson(id);
            }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public static void InsertPeople    (String Name, String Phone, String Region, String Country, String State, String City)
            {
            long phone = Convert.ToInt64(Phone);
            PeopleDL.InsertPeople(Name, phone, Region, Country, State, City);
            }

        public static List<People> GetPeopleList()
        {
            List<People> Peoples = new List<People>();

            DataTable dt = PeopleDL.GetPeople();

            foreach (DataRow dr in dt.Rows)
            {
                People People = new People();
                People.ID = Convert.ToInt16(dr["ID"].ToString());
                People.Name = dr["name"].ToString();
                People.Phone = Convert.ToInt64(dr["phone"].ToString());
                People.Region = dr["region"].ToString();
                People.Country = dr["country"].ToString();
                People.State = dr["state"].ToString();
                People.City = dr["city"].ToString();

            Peoples.Add(People);
            }
            return Peoples;
        }

        
    }

    public class ID_People
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }

        public People getPerson()
        {
            People p = new People();

            DataTable dt = PeopleDL.GetPersonByID(this.PersonID);
            foreach (DataRow dr in dt.Rows)
            {
                p.ID = Convert.ToInt16(dr["ID"].ToString());
                p.Name = dr["Name"].ToString();
                p.Phone = Convert.ToInt64(dr["Phone"].ToString());
                p.Region = dr["Region"].ToString();
                p.Country = dr["Country"].ToString();
                p.State = dr["State"].ToString();
                p.City = dr["City"].ToString();
            }

            return p;
        }

        public static List<ID_People> GetIdOnlyList()
        {
            List<ID_People> people = new List<ID_People>();
            DataTable dt = PeopleDL.GetPeople();

            foreach (DataRow dr in dt.Rows)
            {
                ID_People p = new ID_People();
                p.PersonID = Convert.ToInt16(dr["ID"].ToString());
                p.PersonName = dr["Name"].ToString();


                people.Add(p);
            }

            return people;
        }

        public static List<ID_People> FilterIdOnlyList(string RegionID, string CountryID, string StateID, string CityID)
        {
            List<ID_People> people = new List<ID_People>();
            DataTable dt = PeopleDL.GetFilteredList(RegionID, CountryID, StateID, CityID);

            foreach (DataRow dr in dt.Rows)
            {
                ID_People p = new ID_People();
                p.PersonID = Convert.ToInt16(dr["ID"].ToString());
                p.PersonName = dr["Name"].ToString();


                people.Add(p);
            }

            return people;
        }
    }
}
