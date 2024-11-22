using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaZombie : MonoBehaviour, IZombie
{
    public GameObject bulletPrefab;
    public Transform startPosition;
    public Transform endPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform;
        var vector3 = endPosition.position;
        vector3.z = startPosition.position.z - 30f;
        endPosition.position = vector3;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        StartCoroutine(Attack());

    }

    public void Move()
    {
        
            transform.position += new Vector3( 0, 0, -5 * Time.deltaTime);

        
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(bulletPrefab, -transform.position, Quaternion.identity);
        StartCoroutine(Attack());

    }
}
