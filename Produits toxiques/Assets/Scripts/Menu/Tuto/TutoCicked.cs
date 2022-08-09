using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoCicked : MonoBehaviour
{
    public void OnMouseDown(){
        TutoManager.current.StepPlusOne();
    }
}
