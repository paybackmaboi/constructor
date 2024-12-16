using System;

 class Midterm{
  public void Alas(ref double totalAmount,ref int unit,Display display){

    if(unit<199){
    display.ChargePerUnit = 1.20;
    }
    else if(unit >199 && unit <=299){
    display. ChargePerUnit =2.20; 
    }
    else{
     display.ChargePerUnit =2.20;   
    }
    totalAmount = unit * display.ChargePerUnit;
    totalAmount = Math.Round(unit * display.ChargePerUnit,2 );
    Console.WriteLine("HELLO "+display.Name);
    Console.WriteLine("YOUR ID IS "+display.Id);
    Console.WriteLine("TOTAL AMOUNT CONSUMED IS: "+ totalAmount);

}


}