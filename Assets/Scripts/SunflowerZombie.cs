using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class SunflowerZombie : MonoBehaviour, IZombie
{
    public Transform startPosition;
    
    public static Action IncreaseScore;
    
    public static Action _OnZombieWin;
    [SerializeField]private float speed = 5;
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

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            //_OnZombieWin.Invoke();
            this.gameObject.SetActive(false);
        }

        if (other.CompareTag("Bullet"))
        {
            Debug.Log("flat");
            //IncreaseScore.Invoke();
            //this.gameObject.SetActive(false);
            
        }
    }

    private void Faster()
    {
        SpeedMultiplier += 0.5f;
    }
}
