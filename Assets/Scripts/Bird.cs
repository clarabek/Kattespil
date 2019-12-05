using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject note;

    private void OnTriggerEnter(Collider objectHits)
    {
        Debug.Log("Trigger");
        Instantiate(note);

        if (objectHits.gameObject.tag == "Player")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(500, 500, 3000));
        }
    }
}