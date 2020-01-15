using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Button1 : MonoBehaviour
{
    public GameObject objectShow1;

    private GameObject guiOBject1;

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
        if (guiOBject1)
        {
            Destroy(guiOBject1);
        }
        else
        {
            GameObject mainCamera;
            mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];

            guiOBject1 = Instantiate(objectShow1, mainCamera.transform);
        }
    }
}
