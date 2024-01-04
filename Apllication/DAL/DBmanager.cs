namespace DAL;
//using BLL;
using BOL;
using MySql.Data.MySqlClient;
public class DBmanager{


public static void AddStudent(int id,string fname,string lname)
 {
      MySqlConnection conn1 = new MySqlConnection();
      string query= "insert into Atharva values(@id,@fname,@lname)";
      conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
      MySqlCommand comm4=new MySqlCommand(query,conn1);
      comm4.Parameters.AddWithValue("@id", id);
      comm4.Parameters.AddWithValue("@fname", fname);
       comm4.Parameters.AddWithValue("@lname", lname);
      conn1.Open();
      comm4.ExecuteNonQuery();
      conn1.Close();
 }
 public static void EditStudent(int id,string fname,string lname)
 {
     MySqlConnection conn1=new MySqlConnection();
     string query="Update Atharva set namefirst=@fname,namelast=@lname where ID=@id";
     conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
     MySqlCommand comm2=new MySqlCommand(query,conn1);
     comm2.Parameters.AddWithValue("@fname",fname);
     comm2.Parameters.AddWithValue("@lname",lname);
    comm2.Parameters.AddWithValue("@id",id);
    conn1.Open();
    comm2.ExecuteNonQuery();
    conn1.Close();
}
public static void DeleteStudent(int id)
{
     MySqlConnection conn1=new MySqlConnection();
     string query="Delete from Atharva where ID=@id";
     conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
     MySqlCommand comm2=new MySqlCommand(query,conn1);
     comm2.Parameters.AddWithValue("@id",id);
     conn1.Open();
     comm2.ExecuteNonQuery();
     conn1.Close();
}
public static List<Atharva>GetAllStudent()
{
  List<Atharva> elist=new List <Atharva>();
  MySqlConnection conn1=new MySqlConnection();
  conn1.ConnectionString="server=localhost;user=root;password=admin;database=mysql";
  string query="select * from Atharva";
  MySqlCommand comm=new MySqlCommand(query,conn1);
  conn1.Open();
  MySqlDataReader reader = comm.ExecuteReader();
  while(reader.Read())
  {
    int id=int.Parse(reader["ID"].ToString());
    string namefirst=reader["namefirst"].ToString();
    string namelast=reader["namelast"].ToString();
    Atharva A=new Atharva(id,namefirst,namelast);
    elist.Add(A);
}
 
 conn1.Close();
 return elist;
 

}


}