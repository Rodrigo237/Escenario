using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private Animator playerAnimator;
    public Transform objectToGrab;
    private AnimatorStateInfo currentState;
    public CapsuleCollider capsule;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        capsule = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        currentState = playerAnimator.GetCurrentAnimatorStateInfo(0); //Informacion del estado por layer
        playerAnimator.SetFloat("Speed", Input.GetAxis("Vertical"));
        playerAnimator.SetFloat("Direction", Input.GetAxis("Horinzontal"));

        if (Input.GetKeyDown(KeyCode.Space) && currentState.IsName("Locomotion")) {
            playerAnimator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.Q)){

            playerAnimator.SetTrigger("Wave"); //Mandar un trigger
        }
    }
}
