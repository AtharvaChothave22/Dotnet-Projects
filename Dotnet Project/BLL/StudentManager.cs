namespace Bll;
using BOL;
using DAL;
public static  class StudentManger
{  
 
 public static List<Students> GetallStudents()
 {
   List<Students>slist=new List<Students>();
    slist= DBmanager.GetStudents();
    return slist;
 }
 public static List<Students> GetallStudDetails()
 {
  List<Students>slist=new List<Students>();
    slist= DBmanager.studentq();
    return slist;
 }
 public static List<Students> GetallStudID()
 {
  List<Students>slist=new List<Students>();
    slist= DBmanager.studentid();
    return slist;
 }
}
