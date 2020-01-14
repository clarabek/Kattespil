using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);  
    }


}
