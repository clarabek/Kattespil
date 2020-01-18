using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KittyKat : MonoBehaviour
{
    NavMeshAgent agent;
    //public Inventory inventory;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Input.mousePosition.x;
            x = x - 290;
            float x_cam = Camera.main.transform.position.x;

            if (x < x_cam)
            {

                spriteRenderer.flipX = true;
            }
            if (x > x_cam)
            { spriteRenderer.flipX = false; }

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
                

            }
        }

     
        
    }

   

}
