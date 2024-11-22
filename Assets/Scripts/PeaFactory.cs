using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaFactory : ZombieFactory
{
    public PeaZombie peaZombie;
    
    public override IZombie CreateZombie()
    {
        peaZombie = GameObject.Instantiate(peaZombie);

        return peaZombie;
    }
}
