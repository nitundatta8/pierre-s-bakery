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
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("Pierre offers the following deals: \nBread: Buy 2, get 1 free. A single loaf costs $3 \nPastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("-------------------------------------------------------");
      Console.WriteLine($"Make a selection to browes! \nOption 1 [For Bread] / 2 [For Pastry] / 3 [back]");
      string userInput = Console.ReadLine();
      if(userInput == "1"){
        FindBread(breadList,breadCart,pastryList,pastryCart);
      }else if(userInput == "2"){
        FindPastry(breadList,breadCart,pastryList,pastryCart);
      }else{
        Console.WriteLine("Good Bye"); 
      }
    }

    // BREAD AREA
    public static void FindBread(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart){
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
        AddCart(breadList,breadCart,pastryList,pastryCart,Option);
      }else{
        StartShopping(breadList,breadCart,pastryList,pastryCart);
      }
    }
    // ADD BREAD TO BREAD CART LIST
    public static void AddCart(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart,int option){
      foreach(Bread bread in breadList){
        if(bread.BreadId == option){
          Console.WriteLine($"How many {bread.BreadName} breads do you want?");
          int Quantity = int.Parse(Console.ReadLine());
          Console.WriteLine("va1 " + Quantity);
          for(int i=0;i< Quantity;i++){
            breadCart.Add(bread);
            Console.WriteLine("Bread");
          }
          Console.WriteLine($"{breadCart.Count} {bread.BreadName} bread is added to your cart.");
        }
      }

      Console.WriteLine("Would you like to add more bread items to your cart? [y for yes n for no]");
      string answer = Console.ReadLine();
      answer.ToLower();
      if(answer == "y"){
        FindBread(breadList,breadCart,pastryList,pastryCart);  
      }else{
        Console.WriteLine("Would you like to add any Pastry items to your cart? [y for yes n for no]");
        string answer1 = Console.ReadLine();
        answer1.ToLower(); 
        if(answer1 == "y"){
          StartShopping(breadList,breadCart,pastryList,pastryCart);
        }else{
           PrintItem(breadList,breadCart,pastryList,pastryCart);
        } 
      }
    }
    // PRINT BREAD ITEMS
    public static void PrintItem(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart){
      int totalBPrice =0;
      //string nameB = "";
      int totalPasPrice =0;
      //string name = "";
      int numOfBread = 0;
      int priceOfPastry = 0;
      
      
      foreach(Bread bread in breadCart){
        numOfBread = (breadCart.Count)/2;
        totalBPrice = bread.TotalBreadPrice(breadCart.Count);
      }

      foreach(Pastry pastry in pastryCart){
        priceOfPastry = (pastryCart.Count)/3;
        totalPasPrice = pastry.TotalPastryPrice(pastryCart.Count);
      }
      int balance = totalBPrice + (totalPasPrice - priceOfPastry);
      if(breadCart.Count > 0 && pastryCart.Count > 0){
        Console.WriteLine($"Total Bread:{breadCart.Count + numOfBread} (Deals:{numOfBread} bread free!!)  ${totalBPrice}"+
        $"\nTotal Pastry:{pastryCart.Count} (Deals: ${priceOfPastry} Off!!)      ${totalPasPrice - priceOfPastry} "+
        $"\n ----------------------------- Balance: ${balance}");
      }else if(breadCart.Count > 0){
        Console.WriteLine($"Total Bread:{breadCart.Count + numOfBread} (Deals:{numOfBread} bread free!!)  ${totalBPrice} "+
        $"\n ----------------- Balance: ${balance} ");
      }else if(pastryCart.Count > 0){
         Console.WriteLine($"Total Pastry:{pastryCart.Count}  ${totalPasPrice} (Deals:${priceOfPastry} Off!!)"+
         $" \n ---------- Balance:${balance}");
      }else{
        Console.WriteLine("Hi");
      }
      
      
    }
    //Pastry Area
    // find pastry
    public static void FindPastry(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart){
      Console.WriteLine("Hear is the list of Pastry.Choose option:[1-5]");
      foreach(Pastry pastry in pastryList){
        Console.WriteLine($"{pastry.PastryId}. {pastry.PastryName}    ${pastry.PastryPrice}");
      }
      Console.WriteLine("Would you like to add any items to your cart? [y for yes / n for no]");
      string answer = Console.ReadLine();
      answer.ToLower();
      if(answer == "y"){
        Console.WriteLine("Choose option:[1-5]");
        int Option2 = int.Parse(Console.ReadLine());
        AddPastryToCart(breadList,breadCart,pastryList,pastryCart,Option2);
      }else{
        StartShopping(breadList,breadCart,pastryList,pastryCart);
      }
    }
    //ADD PASTRY TO THE CART

    public static void AddPastryToCart(List<Bread> breadList,List<Bread> breadCart,List<Pastry> pastryList,List<Pastry> pastryCart,int option){
      foreach(Pastry pastry in pastryList){
        if(pastry.PastryId == option){
          Console.WriteLine($"How many {pastry.PastryName} do you want?");
          int Quantity = int.Parse(Console.ReadLine());
          Console.WriteLine("valP " + Quantity);
          for(int i=0;i< Quantity;i++){
            pastryCart.Add(pastry);
          }
          Console.WriteLine($"{pastryCart.Count} {pastry.PastryName} added to your cart.");
        }
      }

      Console.WriteLine("Would you like to add more Pastry items to your cart? [y for yes / n for no]");
      string answer = Console.ReadLine();
      answer.ToLower();
      if(answer == "y"){
        FindPastry( breadList,breadCart,pastryList,pastryCart); 
      }else{
        Console.WriteLine("Would you like to add any Bread items to your cart? [y for yes n for no]");
        string answer1 = Console.ReadLine();
        answer1.ToLower(); 
        if(answer1 == "y"){
          StartShopping(breadList,breadCart,pastryList,pastryCart);
        }else{
          PrintItem(breadList,breadCart,pastryList,pastryCart);

        } 
      }
    }
    //END PASTRY CART
    
   
  }
}

