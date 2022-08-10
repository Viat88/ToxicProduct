using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonController : MonoBehaviour
{

    public GameObject objectToHide;
    public GameObject objectToShow;

    public void Next(){
        if (objectToHide){
            objectToHide.SetActive(false);
        }

        if (objectToShow){
            objectToShow.SetActive(true);
        }
    }
}
