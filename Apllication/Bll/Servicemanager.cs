namespace BLL;
using DAL;
using BOL;
public  static class Servicemanager{
  
  public static void insert(int ID,string fn,string ln)
  {
   DBmanager.AddStudent(ID,fn,ln);
  }
  public static void Edit(int ID,string fn,string ln)
  {
   DBmanager.EditStudent(ID,fn,ln);
  }
   public static void Delete(int ID)
  {
   DBmanager.DeleteStudent(ID);
  }
   public static List<Atharva> GetAllStudent()
  {
    return DBmanager.GetAllStudent();
  }

}