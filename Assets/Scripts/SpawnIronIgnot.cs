using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnIronIgnot : MonoBehaviour
{
    [SerializeField] private float TiemSeconds;
    [SerializeField] public Transform CreateObj;
    public GameObject PrefabIronIgnot;
    public GameObject Minecart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeCreate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator TimeCreate()
    {
        while (true) {
            Debug.Log($"{Minecart.GetComponent<Minecart>().flagAllIgnot} {Minecart.GetComponent<Minecart>().flagStopOldMove}");
            if (Minecart.GetComponent<Minecart>().flagAllIgnot&& Minecart.GetComponent<Minecart>().flagStopOldMove) {
                GameObject IronIgnotClone = Instantiate(PrefabIronIgnot, CreateObj.position, Quaternion.identity) as GameObject;
                IronIgnotClone.name = "IgnotIron";
            }
        yield return new WaitForSeconds(TiemSeconds);
        }
        
    }
}
