using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class SunflowerZombie : MonoBehaviour, IZombie
{
    public Transform startPosition;
    public Transform endPosition;
    public static Action IncreaseScore;
    
    public static Action _OnZombieWin;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform;
        var vector3 = endPosition.position;
        vector3.z = startPosition.position.z - 30f;
        endPosition.position = vector3;
        
        //endPosition.position = Vector3.zero;
        //var vector3 = endPosition.transform.position;

        //var position = endPosition.transform.position;
        //position.z = startPosition.transform.position.z - 10f;
        //endPosition.transform.position = position;
        Debug.Log(endPosition.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
        
            Move();
        
        
    }

    public void Move()
    {
        transform.position = Vector3.Lerp(transform.position, endPosition.position, Time.deltaTime * 1f);
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
}
