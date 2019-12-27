using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject tmpBullet;
    public RectTransform rectTransform;
    private float currentSize;
    public float dynamicSize;
    public float speedCamera;
    public float forceBullet;
    public float minimunSize;
    public bool isActive = false;

     void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }


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

        if (isMoving)
        {
            currentSize = Mathf.Lerp(currentSize, dynamicSize, speedCamera * Time.deltaTime);
        }
        else {
            currentSize = Mathf.Lerp(currentSize, minimunSize, speedCamera * Time.deltaTime);
        }
        rectTransform.sizeDelta = new Vector2(currentSize, currentSize);
    }


    bool isMoving {
        get {
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
                return false;
            else
                return true;
        }
    
    }
}
