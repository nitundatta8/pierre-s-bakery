
namespace Bakery.Models{
  public class Bread{
    public string BreadName{get;set;}
    public string BreadPrice{get;set;}
    
    public Bread(string name , int price){
      BreadName = name;
      BreadPrice = price;
    }

  }

  public class Pastry{
    public string PastryName{get;set;}
    public string PastryPrice{get;set;}
    
    public Pastry(string name , int price){
      PastryName = name;
      PastryPrice = price;
    }

  }
}