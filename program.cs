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
        FindBread(breadList,breadCart);
      }else{
        FindPastry(pastryList,pastryCart);
      }
    }

    // BREAD AREA
    public static void FindBread(List<Bread> breadList,List<Bread> breadCart){
      Console.WriteLine("Hear is the list of Bread.");
      foreach(Bread bread in breadList){
        Console.WriteLine($"{bread.BreadId}.{bread.BreadName}    ${bread.BreadPrice}");
       
      }
      Console.WriteLine("Would you like to add any items to your cart? [y for yes n for no]");
      string answer = Console.ReadLine();
      answer.ToLower();
      if(answer == "y"){
        Console.WriteLine("Choose option:[1-3]");
        int Option = int.Parse(Console.ReadLine());
        AddCart(breadList,Option,breadCart);
      }else{
        Main();
      }
    }
    // ADD BREAD TO BREAD CART LIST
    public static void AddCart(List<Bread> breadList,int option,List<Bread> breadCart){
      foreach(Bread bread in breadList){
        if(bread.BreadId == option){
          Console.WriteLine($"How many {bread.BreadName} breads do you want?");
          int Quantity = int.Parse(Console.ReadLine());
          for(int i=0;i< Quantity;i++){
            breadCart.Add(bread);
          }
          Console.WriteLine($"{breadCart.Count} {bread.BreadName} bread is added to your cart.");
        }
      }

      Console.WriteLine("Would you like to add more bread items to your cart? [y for yes n for no]");
      string answer = Console.ReadLine();
      answer.ToLower();
      if(answer == "y"){
        FindBread(breadList,breadCart);  
      }else{
        Console.WriteLine("Would you like to add any Pastry items to your cart? [y for yes n for no]");
        string answer1 = Console.ReadLine();
        answer1.ToLower(); 
        if(answer1 == "y"){
          Main();
        }else{
           PrintItem(breadList,breadCart);

        } 
      }
    }
    // PRINT BREAD ITEMS
    public static void PrintItem(List<Bread> breadList,List<Bread> breadCart){
      int Total =0;
      string name = "";
      foreach(Bread bread in breadList){
        Total = bread.TotalBreadPrice(breadCart.Count);
      }
      foreach(Bread bread in breadCart){
        name = bread.BreadName;
      }
      Console.WriteLine($"{name} {breadCart.Count} -- Total Price: {Total} \nGood Bye"); 
    }
    //Pastry Area
    public static void FindPastry(List<Pastry> pastryList,List<Pastry> pastryCart){
      Console.WriteLine("Hear is the list of Pastry.Choose option:[1-5]");
      foreach(Pastry pastry in pastryList){
        Console.WriteLine($"{pastry.PastryId}. {pastry.PastryName}    ${pastry.PastryPrice}");
        
      }
    }
  }
}

