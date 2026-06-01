using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MononBehaviour
{
   float health;
    int speed;
    string enemyName;

    int[] intArray = new int[] {1,2,3,4,5,6,7,8,9,10};
    List<int> intList = new List<int>() {1,2,3,4,5,6,7,8,9,10};
    
   void Movement()
   {
      foreach ( int intNumbrs in intArray)
      {
         
      }

     for (int i = 0; i < intArray.Length; i++)
     {
      int currentNumber = intArray[i];
     }

    for (int i = 0; i < intArray.Count; i++)
    {
      int currentNumber = intList[i];
    }
    if (speed > 0)    
   {

   }

   void Dead()
   {
    if (health <= 0)
   }

   void Attack()
   {
   

   } 

   }
}  

public class EnrmyWeapon
   {
      float damage;
      float fireRate;

      void shoot()
   {
      
   }
   }