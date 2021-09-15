using System;

namespace Polimorfismo
{
  class Program
  {
    static void Main()
    {
      Animal dogo = new Dog(); /*the Animal class can ref the new "Dog object"*/
      dogo.Talk();
      dogo.Bite(); /*not gonna work cause "Animal" does not have the a definition for Bite()*/


      /*Cat kitty = new Cat();
       kitty.Talk();*/
    }
  }

  public class Animal
  {
    public virtual void Talk() /*the "virtual" keyword is to say that this method can be overwritten*/
    {
      Console.WriteLine("---");
    }
  }

  public class Dog : Animal
  {
    public override void Talk() /*the "override" keyword is to say that this method is being overwritten*/
    {
      Console.WriteLine("Au-au");

    }

    public void Bite()
    {
      Console.WriteLine("Nhac");
    }

  }
  public class Cat : Animal
  {
    public override void Talk()
    {
      Console.WriteLine("Miau");

    }
  }
}
