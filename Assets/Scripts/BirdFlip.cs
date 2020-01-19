using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlip : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private float x_trans;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        x_trans = transform.position.x;
        Debug.Log(x_trans);
     
        spriteRenderer.flipX = true;
        
    }
}
