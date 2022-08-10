using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneToLoad;
    
    public void OnMouseDown(){
        SceneManager.LoadScene(sceneToLoad);
    }
}
