using System;

class Example6
{

  public class Human
  {
    
  }
  public class Man : Human
  {
    
  }
  public class Woman : Human
  {
     
  }
  public class God
  {

    Man Adam = new Man();
    Woman Eve = new Woman();

    public static Human[] Create()
    {
      return  new Human[] { new Man(), new Woman()};
    }
  }
}