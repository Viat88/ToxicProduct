using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    /*
        Controller of Arrow changing our position
    */
    public Transform nextSphere;

    public void OnMouseDown(){
        SphereChanger.current.StartChangingSphere(nextSphere);
    }

}
