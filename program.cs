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
     List<Bread> breadCart = new List<Bread>(){0};

     Pastry plainDonut = new Pastry("PlainDonut",2);
     Pastry chocolateDonut = new Pastry("ChocolateDonut",2);
     Pastry vanillaCupcake  = new Pastry("VanillaCupcake",2);
     Pastry strawberryCupcake  = new Pastry("StrawberryCupcake",2);
     Pastry chocolateCupcake  = new Pastry("ChocolateCupcake",2);
     List<Pastry> pastryList = new List<Pastry>(){plainDonut,chocolateDonut,vanillaCupcake,strawberryCupcake,chocolateCupcake};

    }
  }
}

