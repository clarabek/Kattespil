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


    // rosa script, screen clamping:


    public bool ZMaxEnabled = false;
    public float ZMaxValue = 0;

    public bool ZMinEnabled = false;
    public float ZMinValue = 0;

    public bool XMaxEnabled = false;
    public float XMaxValue = 0;

    public bool XMinEnabled = false;
    public float XMinValue = 0;

    // rosa script part 1 end
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

        if (ZMinEnabled && ZMaxEnabled)
            targetPos.z = Mathf.Clamp(c_Target.position.z, ZMinValue, ZMaxValue);

        else if (ZMinEnabled)
            targetPos.z = Mathf.Clamp(c_Target.position.z, ZMinValue, c_Target.position.z);

        else if (ZMaxEnabled)
            targetPos.z = Mathf.Clamp(c_Target.position.z, c_Target.position.z, ZMaxValue);



        if (XMinEnabled && XMaxEnabled)
            targetPos.x = Mathf.Clamp(c_Target.position.x, XMinValue, XMaxValue);

        else if (XMinEnabled)
            targetPos.x = Mathf.Clamp(c_Target.position.x, XMinValue, c_Target.position.x);

        else if (XMaxEnabled)
            targetPos.x = Mathf.Clamp(c_Target.position.x, c_Target.position.x, XMaxValue);



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
