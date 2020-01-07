using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject note;

    private void OnTriggerEnter(Collider objectHits)
    {
        Debug.Log("Trigger");
        //Instantiate(note, new Vector3(8f,0.3f,0.3f),transform.rotation);

        if (objectHits.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Animator>().Play("BirdFly");
            GetComponent<Rigidbody>().AddForce(new Vector3(500, 500, 500));
            Instantiate(note, new Vector3(8f, 5f, 0f), transform.rotation);
        }
    }
}