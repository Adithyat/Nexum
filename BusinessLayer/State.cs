using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }

        public static List<State> GetStateList(string CountryID)
        {
            int CID = Convert.ToInt16(CountryID);
            List<State> States = new List<State>();

            DataTable dt = StateDL.GetStates(CID);
            
            foreach (DataRow dr in dt.Rows)
            {
                State State = new State();
                State.StateID = Convert.ToInt16(dr["ID"].ToString());
                State.StateName = dr["name"].ToString();

                States.Add(State);
            }
            return States;
        }
        public static string GetStateName(int ID)
        {
            DataTable dt = StateDL.GetStates(ID);
            DataRow dr = dt.Rows[0];
            return dr["name"].ToString();
        }
    }
}
