using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnRange;
    public Vector3[] spawnPoints = { };
    private StateGame state = new StateGame();
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0f, 5f);
    }

    void spawnEnemy() {
        Instantiate(enemyPrefab, spawnPoints[Random.Range(0, 5)], Quaternion.identity);
        Debug.Log("Position" + enemyPrefab.transform.position);
        state.EnemyCounter();
    }
}
