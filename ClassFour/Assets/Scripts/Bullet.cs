using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject decalPrefab;
    public float offsetDecal;
     void OnCollisionEnter(Collision collision)
    {
        //  decaltmp.transform.parent = objectTransform; // se hace hijo para realizar el seguimiento
        ContactPoint contact = collision.contacts[0];
        //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Quaternion rot = Quaternion.FromToRotation(new Vector3(-1, -1, -1), contact.normal);
        Vector3 pos = collision.contacts[0].point + new Vector3(0.2f,0,0);
        Instantiate(decalPrefab, pos, rot);
        Destroy(this.gameObject);

    }
}
