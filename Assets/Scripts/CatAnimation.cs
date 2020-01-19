using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimation : MonoBehaviour
{
    float Speed;
    Animator anim;
    GameObject target;
    private void OnTriggerEnter(Collider objectHits)
    {
        
        

        if (objectHits.gameObject.tag == "Bird")
        {
           
            gameObject.GetComponent<Animator>().Play("Cat_Attack");
            
         
        }
    }
 
    public void Update()
    {
        
        Speed = gameObject.GetComponentInParent<KittyKat>().SpeedMag;

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Cat_Attack"))
        {
            return;
        }
        if (Speed < 0.15)
        { gameObject.GetComponent<Animator>().Play("Cat_Idle"); }
        if (Speed > 0.15) 
        { gameObject.GetComponent<Animator>().Play("2_Cat_Walk"); }
        
    }

}
