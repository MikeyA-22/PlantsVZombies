using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    public static Action OnHit;
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
    }
}
