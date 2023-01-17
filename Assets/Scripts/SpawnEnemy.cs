using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemy : MonoBehaviour
{
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
            timeRemaining -= Time.deltaTime;
        }
        else
        {

            GameObject CloneEnemy = Instantiate(preabEnemy, transform.position, Quaternion.identity) as GameObject;
            CloneEnemy.name = "Bot";
            timeRemaining = oldtime;
        }
    }
}
