using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class nextbot : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = player.transform.position;
    }
}
