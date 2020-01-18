using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimation : MonoBehaviour
{
    float Speed;

    private void OnTriggerEnter(Collider objectHits)
    {
        Debug.Log("AnimationTrigger");
        //Instantiate(note, new Vector3(8f,0.3f,0.3f),transform.rotation);

        if (objectHits.gameObject.tag == "Bird")
        {
            gameObject.GetComponent<Animator>().Play("Cat_Attack");
        }
    }
    public void Update()
    {
        Speed = gameObject.GetComponentInParent<KittyKat>().SpeedMag;

        if (Speed < 0.15)
        { gameObject.GetComponent<Animator>().Play("Cat_Idle"); }
        else
        { gameObject.GetComponent<Animator>().Play("2_Cat_Walk"); }

    }
}
