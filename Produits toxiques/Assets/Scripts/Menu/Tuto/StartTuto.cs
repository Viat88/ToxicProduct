using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTuto : MonoBehaviour
{
    public void OnMouseDown(){
        TutoManager.current.StepPlusOne();
    }
}
