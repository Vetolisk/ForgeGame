using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemy : MonoBehaviour
{
    private int CountEnemies=0;
    [SerializeField] private int CountE;
    [SerializeField] private TextMeshProUGUI textTimer;
    [SerializeField] private GameObject preabEnemy;
    private float timeRemaining;
   [SerializeField] private float oldtime;

    private void Start()
    {
        timeRemaining = oldtime;
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            updateTimer(timeRemaining);
            timeRemaining -= Time.deltaTime;
            
        }
        else
        {

            GameObject CloneEnemy = Instantiate(preabEnemy, transform.position, Quaternion.identity) as GameObject;
            CloneEnemy.name = "Bot";
            CountEnemies++;
            if (CountEnemies > CountE && oldtime >= 20)
            {
                CountE += 5;
                oldtime -= 5;
                Debug.Log(oldtime);

            }
            timeRemaining = oldtime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CloneEnemy = Instantiate(preabEnemy, transform.position, Quaternion.identity) as GameObject;
            CloneEnemy.name = "Bot";
            CountEnemies++;
            if (CountEnemies > CountE&& oldtime >= 15)
            {
                CountE += 5;             
                oldtime -= 5;
                Debug.Log(oldtime);
                
            }
            timeRemaining = oldtime;
        }
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        textTimer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
