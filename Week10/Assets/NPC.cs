using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class NPC : MonoBehaviour
{
    private NavMeshAgent _Agent;
    public Transform target;
    public float strinDgree;
    public enum NpacStatus
    {
        finding,chasing,attacking
    }

    public NpacStatus status;
    private void Awake()
    {
        _Agent = GetComponent<NavMeshAgent>();
        strinDgree = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(NPCmove());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator NPCmove()
    {
        while (true)
        {
            switch (status)
            {
                case NpacStatus.finding:
                    yield return Find();
                    break;
                case NpacStatus.chasing:
                    yield return Chase();
                    break;
                case NpacStatus.attacking:
                    yield return Attack();
                    break;
            }
            yield return null;
        }
    }

    IEnumerator Find()
    {
        var dir = Random.insideUnitSphere;
        var dest = dir * 5f + transform.position;
        NavMesh.SamplePosition(dest, out var hit, 5f, NavMesh.AllAreas);
        _Agent.destination = hit.position;
        while (_Agent.remainingDistance > 0.1f)
        {
            var dirpos = (target.position - transform.position).normalized;
            var dotpro = Vector3.Dot(dirpos, transform.forward);
            var dagree = MathF.Acos(dotpro) * Mathf.Rad2Deg;
            print(dotpro);
            Physics.Raycast(transform.position,transform.forward,out var hits);
            if (hits.collider != null)
            {
                if (hits.collider.gameObject.name == "Traget" && dagree < strinDgree)
                {
                    status = NpacStatus.chasing;
                    break;
                }

            }

            yield return null;
        }
        
    }
    IEnumerator Chase()
    {
        while (_Agent.remainingDistance > 0.1f)
        {
            _Agent.destination = target.position;
            yield return null;
        }
        status = NpacStatus.attacking;
    }
    IEnumerator Attack()
    {
        while (_Agent.remainingDistance < 0.1f)
        {
            _Agent.destination = target.position;
            
            yield return null;
        }
        status = NpacStatus.finding;
        
    }
    // Update is called once per frame
}
