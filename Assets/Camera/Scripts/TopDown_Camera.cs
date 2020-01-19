using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_Camera : MonoBehaviour
{
    public Transform c_Target;
    public float c_Height;
    public float c_Distance;
    public float c_Angle;
    // Start is called before the first frame update


    


    

    void Start()
    {
        HandleCamera();
    }

    // Update is called once per frame
    void Update()
    {
        // Rosa Script screen clamping part 2 begin
        Vector3 targetPos = c_Target.position;
        targetPos.z = c_Target.position.z;



        Mathf.Clamp(transform.position.x, -83.24313f, 43.2f);
        Mathf.Clamp(transform.position.z, -0.2f, 10.6f);

        // rosa script ends...

        HandleCamera();
    }

    protected virtual void HandleCamera()
    {
        if (!c_Target)
        {
            return;
        }
        //WorldPostition Vector
        Vector3 worldPosition = (Vector3.forward * -c_Distance) +(Vector3.up * c_Height);
        Debug.DrawLine(c_Target.position, worldPosition, Color.red);

        //Building rotated Vector - Gives oppertunity of rotating camera
        Vector3 rotatedVector = Quaternion.AngleAxis(c_Angle, Vector3.up) * worldPosition;
        Debug.DrawLine(c_Target.position, rotatedVector, Color.green);

        //Moving Position so Camera can follow
        Vector3 flatTargetPosition = c_Target.position;
        flatTargetPosition.y = 0f; //Camera won't notice if target go up on bumps ex
        Vector3 finalPosition = flatTargetPosition + rotatedVector;
        Debug.DrawLine(c_Target.position, finalPosition, Color.blue);

        transform.position = finalPosition;
        transform.LookAt(flatTargetPosition);
    }
}
