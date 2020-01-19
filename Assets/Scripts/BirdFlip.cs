using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlip : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private float x_trans;
    private float x;
    Vector3 PrevPos;
    Vector3 NewPos;
    Vector3 Speed;
    public float SpeedMagbird;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        x = -200;

    }

    // Update is called once per frame
    void Update()
    {
        x_trans = transform.position.x;

        NewPos = transform.position;  // each frame track the new position
        Speed = (NewPos - PrevPos) / Time.fixedDeltaTime;  // velocity = dist/time
        PrevPos = NewPos;  // update position for next frame calculation
        SpeedMagbird = Speed.sqrMagnitude;
        if (SpeedMagbird < 0.15)
        { x = x_trans; }

        if (x < x_trans)
        { spriteRenderer.flipX = false; }

        if (x > x_trans)
        { spriteRenderer.flipX = true; }






    }
}
