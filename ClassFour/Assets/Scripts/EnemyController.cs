using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    private Animator enemyAnimator;
    private NavMeshAgent enemyAgent;
    private Transform playerTransform;
    public GameObject player;
    public float countlife = 5f;
    public bool life = true;
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyAgent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(playerTransform.position);
        Debug.Log("Distance to player: " + enemyAgent.remainingDistance);
        enemyAnimator.SetFloat("Speed", enemyAgent.speed);

        if (enemyAgent.remainingDistance <= 1f && enemyAgent.hasPath)
        {

            enemyAnimator.SetFloat("Speed", 0f);
            enemyAnimator.SetBool("Punch", true);
        }
        else
            enemyAnimator.SetFloat("Speed", enemyAgent.speed);
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") {
            countlife = countlife - 1; 
        }
        if (countlife == 0) {
            life = false;
            enemyAnimator.SetBool("Vidas", life);
            Destroy(this.gameObject);
        }

       

    }
}
