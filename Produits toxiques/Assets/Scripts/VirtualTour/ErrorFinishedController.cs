using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorFinishedController : MonoBehaviour
{
    public void tellHeadManager(){
        HeadManager.current.Activate7thError();
    }
}
