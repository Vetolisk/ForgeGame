using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject preabEnemy;
    public int Count;
   
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Count; i++)
        {
            for (int j = 0; i < Count; i++)
            {
                GameObject CloneEnemy = Instantiate(preabEnemy, new Vector3(gameObject.transform.position.x + i, gameObject.transform.position.y, gameObject.transform.position.z+j), Quaternion.identity) as GameObject;
            }
            
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
