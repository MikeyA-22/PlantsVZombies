using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    public static Action RandomAct;
    public static Action FastnStrong;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * 10f;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SZombie")
        {
            SunflowerZombie.IncreaseScore.Invoke();
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        if (other.tag == "PZombie")
        {
            RandomAct.Invoke();
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        if (other.tag == "WZombie")
        {
            FastnStrong.Invoke();
            Debug.Log("Fastn Strong");
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
        
        
    }
}
