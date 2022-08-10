using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizResponseController : MonoBehaviour
{
    public string response;

    public void Clicked(){
        QuizManager.current.Selected(response);
    }
}
