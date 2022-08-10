using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ItemController : MonoBehaviour
{
    public GameObject canvas;
    public bool alreadyFound = false;               // Has to be checked if this item isn't an error (but a next step)

    void OnMouseDown(){
        
        canvas.SetActive(true);

        if (!alreadyFound){
            HeadManager.current.ErrorFound += 1;
            alreadyFound = true;
        }
    }
}
