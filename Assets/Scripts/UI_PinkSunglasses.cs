using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PinkSunglasses : MonoBehaviour
{
    [SerializeField] private Image customImage;


    private void OnMouseDown()
    {
        customImage.enabled = true;
    }

    /*private void OnClick()
    {
        customImage.enabled = false;
    }*/
}
