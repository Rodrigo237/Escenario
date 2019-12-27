using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGame : MonoBehaviour
{
    public static float lifes = 5;
    public float EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void OnGUI()
    {
        GUI.Label( new Rect (10, 10, 100, 20), "Vidas: " + lifes);
        GUI.Label(new Rect(200, 10, 100, 20), "Enemigos Destruidos: " + EnemyCount);
    }

   public void die() {
        if(lifes>0)
            lifes -= 1;
    }

    public void EnemyCounter() {
        EnemyCount += 1;
    }
}
