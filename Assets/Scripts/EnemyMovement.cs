using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    // Enemy movement
    public float sightRadius = 10f;
    Transform target;
    NavMeshAgent agent;
    public Transform centrePoint; 

    // Damage related
    public PlayerHealth currentPlayerHealth;
    public float attackCooldown = 3;
    private float attackTimeLeft;
    
    

    void Start()
    {
        // Finds the player & sets the agent mesh
        target = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Used to delay the attack time of the enemies 
        attackTimeLeft -= Time.deltaTime;

        // Gets the distance the enemy is away from the player to decide if the enemy should begin to chase the player
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= sightRadius)
        {
            FollowPlayer();

        }

        else
        {
            Patrol();
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"){
            
            // Will only attack if there has been enough time since the last attack
            if (attackTimeLeft <= 0f) {
                
               attackTimeLeft = attackCooldown;
               currentPlayerHealth.GetComponent<PlayerHealth>().TakeDamage();
            }
        }
    }

    public void FollowPlayer()
    {
        agent.SetDestination(target.position);
        
    }

    public void Patrol()
    {
        // Generates a random point that the enemy will move to while patrolling
        var randomPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        agent.SetDestination(randomPosition);
    }




}
