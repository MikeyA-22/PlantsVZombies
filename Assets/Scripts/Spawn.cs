using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
   public List<ZombieFactory> zombies = new List<ZombieFactory>();
   private ZombieFactory zombieFactory;
   float timeOfLastSpawn;
   [SerializeField]private float timeBtwSpawn = 5;  
   private void Update()
   {
      
      if (Time.time - timeOfLastSpawn >= timeBtwSpawn )
      {
         Execute();
         timeOfLastSpawn = Time.time;
      }
   }

   public void Execute()
   {
      zombieFactory = zombies[Random.Range(0, zombies.Count)];
      IZombie zombie = zombieFactory.CreateZombie();
   }
}
