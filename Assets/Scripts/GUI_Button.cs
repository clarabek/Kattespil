using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Button : MonoBehaviour
{

    public GameObject objectShow;

    private GameObject guiOBject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void myClick()
    {
        if (guiOBject)
        {
            Destroy(guiOBject);
        }
        else
        {
            GameObject mainCamera;
            mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];

            guiOBject = Instantiate(objectShow, mainCamera.transform);
        }
    }
}
