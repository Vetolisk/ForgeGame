using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISolder : MonoBehaviour
{
    public FieldOfView FOV;
    public GameObject targetObj;
    public int Health;
    [SerializeField] private  int MaxHealth;
    public int SwordDamage;
    public float timeRemaining;
    public float oldtime;
    //public bool timerIsRunning = false;
    void Start()
    {

        timeRemaining = oldtime;
        MaxHealth = Health;
    }
    private void Update()
    {
        if (FOV.canSeePlayer)
        {
            targetObj = FOV.playerRef;
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {

                if (targetObj != null) {
                    if (targetObj.transform.parent.GetComponent<AICharacter>() != null)
                    {
                        targetObj.transform.parent.GetComponent<AICharacter>().SetDamage(SwordDamage);
                    }
                }
                timeRemaining = oldtime;
            }





        }
    }
    public void SetDamage(int damage)
    {
        MaxHealth -= damage;
        if (MaxHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}


