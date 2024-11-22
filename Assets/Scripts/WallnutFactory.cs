using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallnutFactory : ZombieFactory
{
    public WallNutZombie wallNutZombie;
    
    public override IZombie CreateZombie()
    {
        wallNutZombie = GameObject.Instantiate(wallNutZombie);

        return wallNutZombie;
    }
}
