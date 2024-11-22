using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ZombieFactory : MonoBehaviour
{
   public abstract IZombie CreateZombie();
}
