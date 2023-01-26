using System.Drawing;

namespace levelup{
public class Character {

    public string? Name{get; set;}
    public int? MoveCount {get; set;}
    public Point Position (0,0);

    public Character(){
        this.Name = "";
        this.MoveCount = 0;
    }

    public Character(string name){
        this.Name = name;
        this.MoveCount = 0;
    }

    public Point SetPosition(Point pos){
        Position.X = pos.X;
        Position.Y = pos.Y;
    }

    public string GetStatus(){
        return "Character " + this.Name + " is on {" + Position.X.ToString() + "," + Position.Y.ToString() + "} and your Move Count is :" + MoveCount.ToString();
    } 
}
}