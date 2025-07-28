using System;

class Program
{
  public Func<double, double> discountMethod;
  public void SetGlobalDiscount()
  {

  }
  public void SetToPErsonalDiscount(double value)
  {
    Discount discount = new(value);
    discountMethod = discount.ApplyPersonalDiscount;
  }
  static void Main(string[] args)
  {
    Program program = new();
    program.SetToPErsonalDiscount(0.20);
    program.SetGlobalDiscount();


  }
  public class Discount
  {
    private double personalDiscount;
    public Discount(double personalDiscount)
    {
      this.personalDiscount = personalDiscount;
    }
    public double ApplyPersonalDiscount(double price)
    {
      return price * (1 - personalDiscount);
    }

    public static double ApplyGlobalDiscount(double price)
    {
      return price * 0.9;
    }
  }
}