using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public Transform nextSphere;

    public void OnMouseDown(){
        SphereChanger.current.StartChangingSphere(nextSphere);
    }

}
