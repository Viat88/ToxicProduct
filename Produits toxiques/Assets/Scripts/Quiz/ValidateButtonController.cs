using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateButtonController : MonoBehaviour
{
    public void Validate(){
        QuizManager.current.Validate();
    }
}
