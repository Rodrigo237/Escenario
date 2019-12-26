using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeBar : MonoBehaviour
{
    public Image lifeBarImage;
    public Color fullLife;
    public Color emptyLife;
    public float animDuration;
    private float startTime;
    private EnemyController enemyController;
    // Start is called before the first frame update
    void Start()
    {
        lifeBarImage.color = fullLife;
        lifeBarImage.fillAmount = 1;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        lifeBarImage.fillAmount = Mathf.Lerp(1, 0, (Time.time - startTime) / animDuration);  //Interpolar la duración  y el tiempo de la animación
        lifeBarImage.color = Color.Lerp(fullLife, emptyLife, (Time.time - startTime) / animDuration);
    }
}
