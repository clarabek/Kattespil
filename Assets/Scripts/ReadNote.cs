using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadNote : MonoBehaviour
{
    [SerializeField] private Image customImage;

    
        public void ReadPinkNote()
    {
        customImage.enabled = true;
    }

}
