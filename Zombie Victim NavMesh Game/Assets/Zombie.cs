using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    public Transform victim;
    private NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        // agent.destination = victim.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (victim)
        {
            agent.SetDestination(victim.position);
        }
	}
}
