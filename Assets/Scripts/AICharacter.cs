using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacter : MonoBehaviour
{
    public NavMeshAgent agent;
    public int globalDistance = 40;
    public GameObject target;
    public float OldSpeed;
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
        agent.SetDestination(target.transform.position);
        targetObj = GameObject.Find("Artefact");

        timeRemaining = oldtime;
    MaxHealth = Health;
    }
    private void Update()
    {
        if (FOV.canSeePlayer)
        {
            AttackObj = FOV.playerRef;
           
            
          
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
