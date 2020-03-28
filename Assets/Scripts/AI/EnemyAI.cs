using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float detctionRange = 15f;

    [SerializeField] Transform mainTarget;

    public UnityEvent onTargetReached;

    float distance;
    bool isProvoked;

    NavMeshAgent agent;

    Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        CharactersHandler.enemies.Add(this);
    }
    
    private void Update()
    {
        distance = Vector3.Distance(transform.position, mainTarget.position);
        if (distance <= detctionRange)
        {

        }
    }
    /*
    private void RespondToProvokation()
    {
        if (isProvoked)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance && onTargetReached != null)
            {
                onTargetReached.Invoke();
                transform.LookAt(target);
            }
                
        }
    }
    */
    public void Provoke()
    {
        
    }
    /*
    void OnDrawGizmosSelected()
    {
        // Display the chase radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detctionRange);
    }*/

    public Transform GetTarget()
    {
        return mainTarget;
    }

    public float GetRange()
    {
        return detctionRange;
    }
}
