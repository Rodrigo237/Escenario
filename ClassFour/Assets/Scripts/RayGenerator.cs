using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGenerator : MonoBehaviour
{
    public float distance;
    Ray viewRay;
    RaycastHit viewHit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            viewRay = Camera.main.ScreenPointToRay(new Vector3(Screen.width*0.5f,Screen.height*0.5f,0f));

            if (Physics.Raycast(viewRay, out viewHit, distance)) {
                if (viewHit.transform.tag == "Sphere") {
                    viewHit.transform.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 150f); //Impulso
                }
                    }
        }
    }
}
