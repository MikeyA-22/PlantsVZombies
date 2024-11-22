using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class DaveController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed = 10f;
    

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
        SunflowerZombie.IncreaseScore += IncreaseScore;
        Bullet.RandomAct += RandomAction;
        
    }
    

    private void IncreaseScore()
    {
        ScoreManager.Instance.AddScore(10f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(-Input.GetAxis("Vertical"), 0, 0);
        rb.velocity = speed * input.normalized;
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }        
    }

    void RandomAction()
    {
        int random = Random.Range(0, 10);
        if (random > 9)
        {
            rb.AddForce(transform.right * speed);   
        }
    }
}
