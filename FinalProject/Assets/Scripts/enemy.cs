using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class enemy : MonoBehaviour
{
     private NavMeshAgent Mob;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {   
        Mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshHit hit;
        float distance = Vector3.Distance(transform.position, player.transform.position);        
        Vector3 dirToPlayer = transform.position - player.transform.position;
        NavMesh.SamplePosition(transform.position - dirToPlayer, out hit,1000f,NavMesh.AllAreas);
        
        Mob.SetDestination(hit.position);
        
        
    }


    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(2);
    }
}
