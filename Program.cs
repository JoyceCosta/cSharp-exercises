﻿using System;

namespace Polimorfismo
{
  class Program
  {
    static void Main()
    {
      Dog dogo = new Dog();
      dogo.Talk();

      Cat kitty = new Cat();
      kitty.Talk();
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

  }
  public class Cat : Animal
  {
    public override void Talk()
    {
      Console.WriteLine("Miau");

    }
  }
}