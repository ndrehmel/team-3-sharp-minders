using System.Drawing;

namespace levelup{
public class Character {

    public string? Name{get; set;}
    public int? MoveCount {get; set;}
    public Point Position = new Point(0,0);

    public Character(){
        this.Name = "";
        this.MoveCount = 0;
    }

    public Character(string name){
        this.Name = name;
        this.MoveCount = 0;
    }

    public void SetPosition(Point pos){
        Position.X = pos.X;
        Position.Y = pos.Y;
    }

    public void Move(GameController.DIRECTION dir, GameMap gm){
        Point currPos = new Point(this.Position.X, this.Position.Y);
        Point newPos = new Point();
        newPos = gm.calculatePosition(currPos, dir);
        SetPosition(newPos);
        MoveCount=+1;
    }

    public GameController.GameStatus GetStatus(){
        //return "Character " + this.Name + " is on {" + Position.X.ToString() + "," + Position.Y.ToString() + "} and your Move Count is :" + MoveCount.ToString();
        GameController.GameStatus currStatus = new GameController.GameStatus(this.Name, this.Position, (Int32)this.MoveCount);
        return currStatus;
    } 
}
}