using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject preabEnemy;
    public int Count;
    private int length;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Count; i++)
        {
            GameObject CloneEnemy = Instantiate(preabEnemy, new Vector3(gameObject.transform.position.x+length, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity) as GameObject;
            length -= 4;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
