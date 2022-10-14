using System.Collections.Generic;
using System;

class InfomationList{
    static Program program;
    private List<Info> infomationList;

    public InfomationList(){
        this.infomationList = new List<Info>();
    }

    public void AddNewInfo(Info info){
        this.infomationList.Add(info);
    }

    public void CurrentInfo(){
        Console.Clear();
        Console.WriteLine("List Current Person");
        Console.WriteLine("**********");

        foreach(Info info in this.infomationList){
            if(info is CurrentUniStudent){
                Console.WriteLine("Name {0}  Type: Present Student \n", info.GetName());
            } else {
                Console.WriteLine("No Infomation here");
            }
            
        }
    }

    public void StudentInfo(){
        Console.Clear();
        Console.WriteLine("List Student");
        Console.WriteLine("**********");

        foreach(Info info in this.infomationList){
            if(info is Student){
                Console.WriteLine("Name {0}  Type: Present Student \n", info.GetName());
            } else {
                Console.WriteLine("No Infomation here");
            }
            
        }
    }

    public void TeacherInfo(){
        Console.Clear();
        Console.WriteLine("List Teacher");
        Console.WriteLine("**********");

        foreach(Info info in this.infomationList){
            if(info is Teacher){
                Console.WriteLine("Name {0}  Type: Present Student \n", info.GetName());
            } else {
                Console.WriteLine("No Infomation here");
            }
            
        }
    }

}
