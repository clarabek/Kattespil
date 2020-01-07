using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KittyKat : MonoBehaviour
{
    NavMeshAgent agent;
    //public Inventory inventory;
    //public bool freezeRotation;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }

    }
    private void OnTriggerEnter(Collider objectHits)
    {
        Debug.Log("Trigger");
        //Instantiate(note, new Vector3(8f,0.3f,0.3f),transform.rotation);

        if (objectHits.gameObject.tag == "Bird")
        {
            //gameObject.GetComponentInChildren
            gameObject.GetComponent<Animator>().Play("Cat_Jumping");
        }

    }

}
