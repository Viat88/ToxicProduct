using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop3DText : MonoBehaviour
{
    public GameObject text3D;
    void OnMouseEnter(){
        text3D.SetActive(true);
    }

    void OnMouseExit(){
        text3D.SetActive(false);
    }
}
