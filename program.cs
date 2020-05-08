using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery{
  public class Program{
    public static void Main(){
     //CONSTRUCTORS FOR BAKERY ITEMS
     Bread wholeGrain = new Bread(1,"WholeGrain",3);
     Bread white = new Bread(2,"White",3);
     Bread sourdough = new Bread(3,"Sourdough",3);
     List<Bread> breadList = new List<Bread>(){wholeGrain,white,sourdough};
     List<Bread> breadCart = new List<Bread>(0);

     Pastry plainDonut = new Pastry(1,"PlainDonut",2);
     Pastry chocolateDonut = new Pastry(2,"ChocolateDonut",2);
     Pastry vanillaCupcake  = new Pastry(3,"VanillaCupcake",2);
     Pastry strawberryCupcake  = new Pastry(4,"StrawberryCupcake",2);
     Pastry chocolateCupcake  = new Pastry(5,"ChocolateCupcake",2);
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
      Console.WriteLine("Hear is the list of Bread. Choose option:[1-3]");
      foreach(Bread bread in breadList){
        Console.WriteLine($"{bread.BreadId}.{bread.BreadName}    ${bread.BreadPrice}");
       
      }
      int Option = int.Parse(Console.ReadLine());
      //GetPrice(breadList,Option);
      
    }
    // public static GetPrice(List<T>list,int Option){
    // if()  
    // Console.WriteLine($"How many {list[Option-1].BreadName} bread do you want?");
    // }
    //Pastry Area
    public static void FindPastry(List<Pastry> pastryList){
      Console.WriteLine("Hear is the list of Pastry.Choose option:[1-5]");
      foreach(Pastry pastry in pastryList){
        Console.WriteLine($"{pastry.PastryId}. {pastry.PastryName}    ${pastry.PastryPrice}");
        
      }
    }
  }
}

