using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    GameObject[] goalLocations;
    NavMeshAgent agent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        goalLocations = GameObject.FindGameObjectsWithTag("goal");
        int i= Random.Range(0, goalLocations.Length);
        agent.SetDestination(goalLocations[i].transform.position);
        anim = this.GetComponent<Animator>();
        anim.SetTrigger("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance < 1)
        {
            int i = Random.Range(0, goalLocations.Length);
            agent.SetDestination(goalLocations[i].transform.position);
        }
    }
}
