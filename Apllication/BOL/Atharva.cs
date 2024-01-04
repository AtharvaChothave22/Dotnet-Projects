namespace BOL;

public class Atharva{
    public int ID{get;set;}

    public string namefirst{get;set;}

    public string namelast{get;set;}
    
    public Atharva(int id,string fname,string lname)
    {
        this.ID=id;
        this.namefirst=fname;
        this.namelast=lname;
    }
}