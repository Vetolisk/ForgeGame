using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyCave : MonoBehaviour
{
    public Transform[] SpawnEnemyCount;
    public GameObject Enemy;
    void Start()
    {
        int Count=Random.Range(0,4);
        GameObject CloneEnemy=Instantiate(Enemy,SpawnEnemyCount[Count].position,Quaternion.identity);
    }
}
