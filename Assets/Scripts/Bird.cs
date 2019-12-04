using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private void OnCollisionEnter(Collision objectHits)
    {
        if (objectHits.gameObject.name == "KittyKat")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(500, 500, 0));
        }
    }
}