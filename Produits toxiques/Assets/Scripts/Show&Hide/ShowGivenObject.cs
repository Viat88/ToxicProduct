using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGivenObject : MonoBehaviour
{
    public GameObject objectToShow;
    public bool toShow;

    public void OnMouseDown(){
        objectToShow.SetActive(toShow);
    }
}
