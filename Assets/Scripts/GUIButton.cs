using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIButton : MonoBehaviour
{
    public GameObject sunglasses;

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
        else { 
        GameObject mainCamera;
        mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];

        guiOBject = Instantiate(sunglasses, mainCamera.transform);
        }
    }
}
