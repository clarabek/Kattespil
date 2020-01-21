using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KittyKat : MonoBehaviour
{
    NavMeshAgent agent;
    //public Inventory inventory;
    SpriteRenderer spriteRenderer;
    Vector3 PrevPos;
    Vector3 NewPos;
    Vector3 Speed;
    public float SpeedMag;
  

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
      

    }

    public void Update()
    {

        NewPos = transform.position;  // each frame track the new position
        Speed = (NewPos - PrevPos) / Time.fixedDeltaTime;  // velocity = dist/time
        PrevPos = NewPos;  // update position for next frame calculation
        SpeedMag = Speed.sqrMagnitude;
      

        if (Input.GetMouseButtonDown(0))
        {
            float x = Input.mousePosition.x;
            x = x - 1700;
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
