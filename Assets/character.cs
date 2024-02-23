using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    
   public string name;
   private int healthPoints = 10;
   public Character(string name)
       {
           this.name = name;

       }

       ~Character()
       {
           Debug.Log("Destroyed");
       }

   public int getHealthPoints()
   {
       return healthPoints;
   }
}
