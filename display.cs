using System;
class Display{
private string? name;
private int id;
private int unit;
private double totalAmount = 0;
private int paingon;
private double chargePerUnit;
private Midterm love = new Midterm();
public string Name{
    get{return name??"0";}
    set{name = value;}
}
public int Id{
    get{return id;}
    set{id = value;}
}
public int Unit{
    get{return unit;}
    set{unit = value;}
}
public double TotalAmount{
    get{return totalAmount;}
    set{totalAmount = value;}
}
public int Paingon{
    get{return paingon;}
    set{paingon = value;}
}
public double ChargePerUnit{
    get{return chargePerUnit;}
    set{chargePerUnit = value;}
}
public void Function(){
    
    Here:
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    Console.Write("Enter your Id: ");
    id = int.Parse(Console.ReadLine()??"0");
    Console.Write("Enter unit: ");
    unit = int.Parse(Console.ReadLine()??"0");


    love.Alas(ref totalAmount,ref unit, this);

    Console.Write("Enter 1 to continue and 0 to exit: ");
    paingon = int.Parse(Console.ReadLine()??"0");
    if(paingon==0){
        Console.WriteLine("EXITINGGSS");
    }
    else{
        goto Here;
    }
}


}