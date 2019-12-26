using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float smooth = 0.3f;
    public float distance = 5.0f;
    public float height = 3.5f;
    private float yVelocity = 0f;

    // Update is called once per frame
    void Update()
    {
        float yangle = Mathf.SmoothDampAngle(
            transform.eulerAngles.y, target.eulerAngles.y, ref yVelocity, smooth);
        Vector3 position = target.position;
        position += Quaternion.Euler(0, yangle, 0) * new Vector3(0, height, -distance);

        transform.position = position;
        transform.LookAt(target);
    }
}
