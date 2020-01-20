using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimation : MonoBehaviour
{
    float Speed;
    Animator anim;
    GameObject target;
    private bool playTriggerAnimation;
    private bool time;
    float timeLeft = 2f;

    public void Start()
    {
        playTriggerAnimation = true;
    }

    public void Update()
    {
        
        Speed = gameObject.GetComponentInParent<KittyKat>().SpeedMag;
        anim = gameObject.GetComponent<Animator>();
        

        if (playTriggerAnimation == true)
        {
            if (Speed < 0.15)
        {
            gameObject.GetComponent<Animator>().Play("Cat_Idle");
        }
            if (Speed > 0.15)
        {
                gameObject.GetComponent<Animator>().Play("2_Cat_Walk");
                
            }
        }

        if (time == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            { playTriggerAnimation = true;
                timeLeft = 2f;
            }

                    }



    }
    private void OnTriggerEnter(Collider objectHits)
    {



        if (objectHits.gameObject.tag == "Bird")
        {
            playTriggerAnimation = false;

            Debug.Log("Triggered");
            gameObject.GetComponent<Animator>().Play("Cat_Attack");
            time = true;
           
           
        }


    }
 


}
