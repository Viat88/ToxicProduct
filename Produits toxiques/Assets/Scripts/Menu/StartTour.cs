using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTour : MonoBehaviour
{
    public void OnMouseDown(){
        SceneManager.LoadScene("Tour");
    }
}
