using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerFactory : ZombieFactory
{
    
    public SunflowerZombie sunflower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override IZombie CreateZombie()
    {
        sunflower = GameObject.Instantiate(sunflower);
        
        return sunflower;
    }
}
