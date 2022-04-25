using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PROJECT
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable ViewTransfers()
        {
            string query = "SELECT * FROM Transfer_Market;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewStandings()
        {
            string query = "SELECT * FROM Standings;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewSchedule()
        {
            string query = "SELECT * FROM FMatch;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllplayers()
        {
            string query = "SELECT * FROM Football_Player;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllClubs()
        {
            string query = "SELECT * FROM Football_Club;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllReferees()
        {
            string query = "SELECT * FROM Referee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllCoaches()
        {
            string query = "SELECT * FROM Coach;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewClub(string ClubName)
        {
           string query = "SELECT * FROM Football_Club"
             + " where Club_Name='" + ClubName + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewPlayer(string Player_name,int season)
        {
            string query = "SELECT * FROM Football_Player"
             + " where Fname='" + Player_name + "'AND Season='" + season + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewCoach(string Fname,int season)
        {
            string query = "SELECT * FROM Coach"
             + " where Fname='" + Fname + "'AND Season='" + season + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewReferee(string Referee_name,int season)
        {
            string query = "SELECT * FROM Referee"
             + " where Fname='" + Referee_name + "'AND Season='" + season + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTicket_Status(string HomeTeam,string AwayTeam)
        {
            string query = "SELECT Stat FROM Tickets_Availability T,FMatch F"
                + " WHERE T.Match_ID=F.Match_ID AND F.Away_Team='" + AwayTeam + "'AND F.Home_Team='" + HomeTeam + "';";
            return dbMan.ExecuteReader(query);
        }
        public int UPDATE_BUDGET(string Budget,int CLUB_id)
        {
            string query = "UPDATE Football_Club SET Club_Budget='" + Budget + "'WHERE Club_ID=" + CLUB_id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UPDATE_STADIUM(int capacity,int club_ID)
        {
            string query = "UPDATE Stadium SET Capacity=" + capacity + "WHERE Club_ID=" + club_ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int INSERT_SPONSOR(string Spons_NAME,int ID,int season)
        {
            string query = "INSERT INTO Sponsor " +
                            "Values ('" + Spons_NAME + "'," + ID + "," + season + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DELETES(int END_D, int SNO, int CNO)
        {
            string query = "UPDATE Has SET End_date=" + END_D + " WHERE Sponsor_ID=" + SNO + "AND Club_ID=" + CNO + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SELECTALLP(int SEAS)
        {
            string query = "SELECT * FROM Football_Player WHERE Season=" + SEAS + "ORDER BY Goals DESC" + ";";
            return dbMan.ExecuteReader(query);
        }

        //SELECT SPECIFIC PLAYERS
        public DataTable SELECTP(string Player_name, int season)
        {
            string query = "SELECT * FROM Football_Player"
             + " where Fname='" + Player_name + "'AND Season='" + season + "';";
            return dbMan.ExecuteReader(query);
        }

        //SELECT ALL CLUBS
        public DataTable SELECTALLCLUB()
        {
            string query = "SELECT * FROM Football_Club;";
            return dbMan.ExecuteReader(query);
        }

        //SELECT SPECIFIC CLUBS
        public DataTable SELECTCLUB(string ClubName)
        {
            string query = "SELECT * FROM Football_Club"
             + " where Club_Name='" + ClubName + "';";
            return dbMan.ExecuteReader(query);
        }
       
        //UPDATE PLAYER BY COACH
        public int UpdateP(string POS, string ROLE, int Pid, int SEAS)
        {
            string query = "UPDATE Football_Player SET Player_Position='" + POS + "',PRole='" + ROLE + "' WHERE ID=" + Pid + "AND Season=" + SEAS + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        //SELECT PLAYERS ID
        public DataTable SELECTPID()
        {
            string query = "SELECT ID FROM Football_Player WHERE Club_ID='" + 100 + "';";
            return dbMan.ExecuteReader(query);
        }

        //////////////////////////////////////////////////////////////////////////////////
        public int InsertSponsor(string sponame, int id, int season)
        {
            string query = "INSERT INTO Sponsor (Sponsor_Name, Sponsor_ID, Season)" +
                            "Values ('" + sponame + "'," + id + "," + season + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Inserttrans(int tranid, int fee, DateTime trandate, string tj, string tl, int pid, int season)
        {
            string query = "INSERT INTO Transfer_Market " +
                            "Values (" + tranid + "," + pid + "," + season + ",'" + tl + "','" + tj + "'," + fee + ",'" + trandate + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllTrans()
        {
            string query = "SELECT * FROM Transfer_Market ORDER BY Fee DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllTrans1()
        {
            string query = "SELECT * FROM Transfer_Market WHERE Season=1 ORDER BY Fee DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllTrans2()
        {
            string query = "SELECT * FROM Transfer_Market WHERE Season=2 ORDER BY Fee DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectClubname()
        {
            string query = "SELECT Club_Name FROM Football_Club;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectMatchID()
        {
            string query = "SELECT Match_ID FROM FMatch;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectPlayerid()
        {
            string query = "SELECT ID FROM Football_Player;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectCoachid()
        {
            string query = "SELECT Coach_ID FROM Coach;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectreferee()
        {
            string query = "SELECT Referee_ID FROM Referee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectstadium()
        {
            string query = "SELECT Stadium_Name FROM Stadium;";
            return dbMan.ExecuteReader(query);
        }
        public int Updatematchshedule(int mid, DateTime date, int refid, string stad)
        {
            string query = "UPDATE FMatch SET Stadium='" + stad + "', MDate='" + date + "', Referee_ID=" + refid + " WHERE Match_ID=" + mid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertMatch(int Mid, DateTime Mdate, int refid, string stad, string Hteam, string Ateam, int season)
        {
            string query = "INSERT INTO FMatch (Match_ID, MDate, Referee_ID, Stadium, Home_Team, Away_Team, season) " +
                            "Values (" + Mid + ",'" + Mdate + "'," + refid + ",'" + stad + "','" + Hteam + "','" + Ateam + "'," + season + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updateprize(string p1, string p2)
        {
            string query = "UPDATE Tournament SET Pfirst='" + p1 + "', PSecond='" + p2 + "' WHERE Season=" + 2 + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateCoach(int id, string salary, int ses)
        {
            string query = "UPDATE Coach SET Salary='" + salary + "' WHERE Season=" + ses + " AND Coach_ID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertStanding(string Tname, int g, int w, int l, int d, int clsheat, int no, int pts, int season)
        {
            string query = "INSERT INTO Standings (Goals, wins, loses,Draw, Clean_Sheet, Matches_Played, Points,Club_Name, Season) " +
                            "Values (" + g + "," + w + "," + l + "," + d + "," + clsheat + "," + no + "," + pts + ",'" + Tname + "'," + season + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStanding(string Tname, int g, int w, int l, int d, int clsheat, int no, int pts, int se)
        {
            string query = "UPDATE Standings SET Goals=" + g + ", wins=" + w + ", loses=" + l + ", Draw=" + d + ", Clean_Sheet=" + clsheat + ", Matches_Played=" + no + ", Points=" + pts + " WHERE Club_Name='" + Tname + "' AND Season=" + se + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int inserttiktsavail(int Mid, string m)
        {
            string query = "INSERT INTO Tickets_Availability (Match_ID, Stat)" +
                            "Values (" + Mid + ",'" + m + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatetiktsavail(int Mid, string m)
        {
            string query = "UPDATE Tickets_Availability SET Stat='" + m + "' WHERE Match_ID='" + Mid + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updateplayer(int assit, int goals, int id, string salary, int ses)
        {
            string query = "UPDATE Football_Player SET Assists=" + assit + ", Goals=" + goals + ", Salary='" + salary + "' WHERE ID=" + id + " AND Season=" + ses + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable CHECK_USER_PASS(string username,int password)
        {
            string query = "SELECT * FROM C_USERS"
             + " where USERNAME='" + username + "'AND PASS_WORD='" + password + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CHECK_USER_PASS1(string username, int password)
        {
            string query = "SELECT * FROM Club_Admin_USERS"
             + " where USERNAME='" + username + "'AND PASS_WORD='" + password + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CHECK_USER_PASS2(string username, int password)
        {
            string query = "SELECT * FROM Admin_USERS"
             + " where USERNAME='" + username + "'AND PASS_WORD='" + password + "';";
            return dbMan.ExecuteReader(query);
        }
        public int insertnewadmin(int Mid, string m)
        {
            string query = "INSERT INTO Admin_USERS (USERNAME, PASS_WORD)" +
                            "Values ('" + m + "'," + Mid + ");";
            return dbMan.ExecuteNonQuery(query);
        }


        //SELECT ALL TRANSFERES   PROC
        public DataTable SELECTTRANS(int SEAS)
        {
            string query = "EXEC SELECTTRANS @SEAS= " + SEAS + ";";
            return
            dbMan.ExecuteReader(query);
        }
        //SELECT SCHEDULE  PROC
        public DataTable SELECTSCHED(int SEAS)
        {
            string query = "EXEC SELECTSCHED @SEAS= " + SEAS + ";";
            return
            dbMan.ExecuteReader(query);
        }

        //SELECT STANDINGS (COMPLEX QUEREY)  PROC
        public DataTable SELECTSTAND(int SEAS)
        {
            string query = "EXEC SELECTSTAND @SEAS= " + SEAS + ";";
            return
            dbMan.ExecuteReader(query);
        }

        //GET BEST PLAYER PROC
        public DataTable SELECTBESTPLAYER(int SEAS)
        {
            string query = "EXEC SELECTBESTPLAYER @SEAS= " + SEAS + ";";
            return
            dbMan.ExecuteReader(query);
        }


        //GET OLDEST PLAYER  PROC

        public DataTable SELECTOLDESTPLAYER(int SEAS)
        {
            string query = "EXEC SELECTOLDESTPLAYER @SEAS= " + SEAS + ";";
            return
            dbMan.ExecuteReader(query);
        }



        public int insertnewadmin1(string username, int password)
        {
            string query = "INSERT INTO S_USERS (USERNAME, PASS_WORD)" +
                            "Values ('" + username + "'," + password + ");";
            return dbMan.ExecuteNonQuery(query);
        }




        public int updatetiktsavail2(string m,int Mid)
        {
            string query = "UPDATE Admin_USERS SET PASS_WORD=" + Mid + " WHERE USERNAME='" + m + "';";
            return dbMan.ExecuteNonQuery(query);
        }

    }
}
