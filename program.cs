using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery{
  public class Program{
    public static void Main(){
     //CONSTRUCTORS FOR BAKERY ITEMS
     Bread wholeGrain = new Bread("WholeGrain",3);
     Bread white = new Bread("White",3);
     Bread sourdough = new Bread("Sourdough",3);
     List<Bread> breadList = new List<Bread>(){wholeGrain,white,sourdough};
     List<Bread> breadCart = new List<Bread>(0);

     Pastry plainDonut = new Pastry("PlainDonut",2);
     Pastry chocolateDonut = new Pastry("ChocolateDonut",2);
     Pastry vanillaCupcake  = new Pastry("VanillaCupcake",2);
     Pastry strawberryCupcake  = new Pastry("StrawberryCupcake",2);
     Pastry chocolateCupcake  = new Pastry("ChocolateCupcake",2);
     List<Pastry> pastryList = new List<Pastry>(){plainDonut,chocolateDonut,vanillaCupcake,strawberryCupcake,chocolateCupcake};
     List<Pastry> pastryCart = new List<Pastry>(0);
     StartShopping(breadList,breadCart,pastryList,pastryCart);
    }
    public static void StartShopping(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart){
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine($"Make a selection to browes! \nOption 1 [For Bread]/ 2 [For Pastry]");
      string userInput = Console.ReadLine();
      if(userInput == "1"){
        FindBread(breadList);
      }else{
        FindPastry(pastryList);
      }
    }

    // BREAD AREA
    public static void FindBread(List<Bread> breadList){
      Console.WriteLine("Hear is the list of Bread");
      foreach(Bread bread in breadList){
        Console.WriteLine($"{bread.BreadName}    ${bread.BreadPrice}");
      }
    }
    public static void FindPastry(List<Pastry> pastryList){
      int count=1;
      Console.WriteLine("Hear is the list of Pastry");
      foreach(Pastry pastry in pastryList){
        Console.WriteLine($"{count}. {pastry.PastryName}    ${pastry.PastryPrice}");
        count++;
      }
    }
  }
}

