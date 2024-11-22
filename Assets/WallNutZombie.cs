using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallNutZombie : MonoBehaviour, IZombie
{
    public Transform startPosition;
    
    
    [SerializeField]private float speed = 1;
    [SerializeField]private float SpeedMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        Bullet.FastnStrong += Faster;
        startPosition = this.transform;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Move();
        
        
    }

    public void Move()
    {
        transform.position += new Vector3( 0, 0, -speed * Time.deltaTime * SpeedMultiplier);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            //_OnZombieWin.Invoke();
            this.gameObject.SetActive(false);
        }

        
    }
    
    private void Faster()
    {
        SpeedMultiplier += 0.5f;
    }
}
