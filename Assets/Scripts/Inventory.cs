using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private float dirX, dirY;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = new Vector2
            (
            Mathf.Clamp(transform.position.x, -83.24313f, 43.2f),
            Mathf.Clamp(transform.position.z, -0.2f, 10.6f));
            
    }
}
