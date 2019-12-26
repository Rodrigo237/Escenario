using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject tmpBullet;
    public float forceBullet;
    public bool isActive = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isActive)
        {
            tmpBullet = Instantiate(bulletPrefab,
                            transform.position, Quaternion.identity);

            tmpBullet.transform.up = transform.forward;
            tmpBullet.GetComponent<Rigidbody>().AddForce(transform.forward * forceBullet,ForceMode.Impulse);
        }
        }
}
