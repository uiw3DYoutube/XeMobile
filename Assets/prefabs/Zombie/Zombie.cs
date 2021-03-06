using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Zombie : Character
{
    NavMeshAgent navAgent;
    Animator animator;
    Rigidbody ZombieRigidbody;
    float speed;
    Vector3 previousLocation;
    [SerializeField] BoxCollider AttackRange;

    // Start is called before the first frame update
    public override void Start() 
    {
        navAgent = GetComponent<NavMeshAgent>();
        base.Start();
        animator = GetComponent<Animator>();
        ZombieRigidbody = GetComponent<Rigidbody>();
        previousLocation = transform.position;
    }

    internal void Attack()
    {
        animator.SetLayerWeight(1, 1);
    }
    public void AttackPoint()
    {
        Collider[] targets = Physics.OverlapBox(AttackRange.bounds.center, AttackRange.bounds.extents, AttackRange.transform.rotation);
        foreach(var target in targets)
        {
            Player targetAsPlayer = target.GetComponent<Player>();
            if(targetAsPlayer)
            {
                target.GetComponent<HealthComponent>().TakeDamage(1, gameObject);
            }
        }
    }
    public void AttackFinished()
    {
        animator.SetLayerWeight(1, 0);
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        float MoveDelta = Vector3.Distance(transform.position, previousLocation);
        speed = MoveDelta / Time.deltaTime;
        previousLocation = transform.position; 
        animator.SetFloat("Speed", speed);
    }
}
