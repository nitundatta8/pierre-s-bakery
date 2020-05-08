
namespace Bakery.Models{
  public class Bread{
    public string BreadName{get;set;}
    public string BreadPrice{get;set;}
    
    public Bread(string name , int price){
      BreadName = name;
      BreadPrice = price;
    }
    
    public int TotalBreadPrice(int Item){
      int Breadprice = 3;
      int Total =  Item *  Breadprice;
      return Total;
    }
  }

  public class Pastry{
    public string PastryName{get;set;}
    public string PastryPrice{get;set;}
    
    public Pastry(string name , int price){
      PastryName = name;
      PastryPrice = price;
    }

    public int TotalPastryPrice(int Item){
      int Pastryprice = 2;
      int Total =  Item *  Pastryprice;
      return Total;
    }

  }
}