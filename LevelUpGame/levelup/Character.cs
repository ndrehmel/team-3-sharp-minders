namespace levelup{
public class Character {

    public string? Name{get; set;}
    public int? MoveCount {get; set;}

    public Character(){
        this.Name = "";
        this.MoveCount = 0;
    }

    public Character(string name){
        this.Name = name;
        this.MoveCount = 0;
    }
}
}