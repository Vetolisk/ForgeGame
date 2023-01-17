using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharacter : MonoBehaviour
{
    public float OldSpeed;
    public RichAI RAI;
    public AIDestinationSetter AID;
    public FieldOfView FOV;
    public GameObject targetObj;
    public GameObject AttackObj;
    public int Health;
    [SerializeField] private int MaxHealth;
    public int SwordDamage;
    public float timeRemaining;
    public float oldtime;
    //public bool timerIsRunning = false;
    void Start()
    {
        OldSpeed = RAI.maxSpeed;
        targetObj = GameObject.Find("Artefact");

        timeRemaining = oldtime;
    MaxHealth = Health;
    }
    private void Update()
    {
        if (FOV.canSeePlayer)
        {
            AttackObj = FOV.playerRef;
           
            
            RAI.maxSpeed = 0;
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                if (AttackObj!=null) {
                    AttackObj.transform.parent.GetComponent<AISolder>().SetDamage(SwordDamage);
                }
                    
                



                timeRemaining = oldtime;
            }





        }
        else
        {
            
            AID.target = targetObj.transform;
            RAI.maxSpeed = OldSpeed;
        }
    }
    public void SetDamage(int damage)    
    {
        MaxHealth -= damage;
        if (MaxHealth<=0)
        {
            Destroy(gameObject);
        }
    }
}
