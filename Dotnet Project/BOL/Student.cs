public class Students{
    public int ID{get;set;}

    public string namefirst{get;set;}

    public string  namelast{get;set;}

    public string  name{get;set;}

    public string  college{get;set;}
       
    public string  university{get;set;}
    
   
    public Students(int id,string namefirst,string namelast)
    {
        this.ID=id;
        this.namefirst=namefirst;
        this.namelast=namelast;
    }
     public Students(int id,string name,string college,string university)
    {
        this.ID=id;
        this.name=name;
        this.college=college;
        this.university=university;

    }

}
