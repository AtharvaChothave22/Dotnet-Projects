namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public static class DBmanager
{   
    
    public static List<Students>GetStudents()
    {  MySqlConnection conn = new MySqlConnection();
      
      
       List<Students> li = new List<Students>();
       
        conn.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
        string query = "select ID, namefirst,namelast from Student";

        try
        {
            MySqlCommand comm1 = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = comm1.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["namefirst"].ToString();
                string NamLast=reader["namelast"].ToString();
                Students s1 = new Students(ID,Name,NamLast);
             
                li.Add(s1);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return li;
    }
    
    
     public static List<Students>studentid()
    {   
         MySqlConnection conn2 = new MySqlConnection();
         List<Students> li = new List<Students>();
        conn2.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
         string query = "select ID, namefirst,namelast from Student where Id=2";
       try
        {
            MySqlCommand comm2 = new MySqlCommand(query, conn2);
            conn2.Open();
            MySqlDataReader reader = comm2.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["namefirst"].ToString();
                string NamLast=reader["namelast"].ToString();
                Students s2 = new Students(ID,Name,NamLast);
                li.Add(s2);
                }
      }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn2.Close();
        }
        return li;
    }

public static List<Students>studentq()
    {   
        MySqlConnection conn1 = new MySqlConnection();
         List<Students> li = new List<Students>();
         conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
        string query = "select ID, name,college,university from Student_qualifications";
       try
        {
            MySqlCommand comm2 = new MySqlCommand(query, conn1);
            conn1.Open();
            MySqlDataReader reader = comm2.ExecuteReader();
            while (reader.Read())
            {
                int ID = int.Parse(reader["ID"].ToString());
                string Name = reader["name"].ToString();
                string NamLast=reader["college"].ToString();
                string University=reader["university"].ToString();
                Students s2 = new Students(ID,Name,NamLast,University);
                li.Add(s2);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn1.Close();
        }
        return li;
    }
 public static void AddStudent(string nm,string em)
 {
      MySqlConnection conn1 = new MySqlConnection();
      string query= "insert into register (Name,Email) values(@n,@e)";
      conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
      MySqlCommand comm4=new MySqlCommand(query,conn1);
      comm4.Parameters.AddWithValue("@n", nm);
      comm4.Parameters.AddWithValue("@e", em);
      conn1.Open();
      comm4.ExecuteNonQuery();
      conn1.Close();
 }
 public static bool ValidateUser(string p,string e)
 {    
       MySqlConnection conn1 = new MySqlConnection();
       bool isvalid=false;
       string query = "select count(*) from login where password=@pass and emailid=@em";
         conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
     try
        {   
         MySqlCommand comm2 = new MySqlCommand(query, conn1);
         comm2.Parameters.AddWithValue("@pass",p);
         comm2.Parameters.AddWithValue("@em",e);
         conn1.Open();
         int count =Convert.ToInt32(comm2.ExecuteScalar());
         if(count>=1)
         {
            isvalid=true;
         }
    }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            conn1.Close();
        }
        return  isvalid;
 }
 public static void Update(string fn,string ln, int id)
 {
    MySqlConnection conn1 = new MySqlConnection();
    conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
    string query="Update student set namefirst=@n , namelast=@l where ID=@i";
    MySqlCommand comm1=new MySqlCommand(query,conn1);
    try{
      conn1.Open();
      comm1.Parameters.AddWithValue("@n",fn);
      comm1.Parameters.AddWithValue("@l",ln);
      comm1.Parameters.AddWithValue("@i",id);
      comm1.ExecuteNonQuery();
     }
     catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            conn1.Close();
        }
 }
 public static  void DeleteByid(int id)
 {
    MySqlConnection conn1 = new MySqlConnection();
    conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
    string query="delete  from Atharva where ID=@d";
    MySqlCommand comm1=new MySqlCommand(query,conn1);
    conn1.Open();
    comm1.Parameters.AddWithValue("@d",id);
    comm1.ExecuteNonQuery();
    conn1.Close();
 }

}
