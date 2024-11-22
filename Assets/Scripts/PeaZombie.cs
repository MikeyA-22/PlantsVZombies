using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaZombie : MonoBehaviour, IZombie
{
    public GameObject bulletPrefab;
    public Transform startPosition;
    float timeOfLastShot;
    float timeBtwShots = 5f;

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
        StartCoroutine(Attack());

    }

    public void Move()
    {
        
        transform.position += new Vector3( 0, 0, -speed * Time.deltaTime * SpeedMultiplier );

        
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(3f);
        if (Time.time - timeOfLastShot >= timeBtwShots )
        {
            Shoot();
            timeOfLastShot = Time.time;
        }        
        StartCoroutine(Attack());

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
    
    private void Faster()
    {
        SpeedMultiplier += 0.5f;
    }
}
