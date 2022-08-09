using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas11sController : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    private bool alreadyDone = false;

    
    void Start()
    {}

    void Update()
    {
        if (player.transform.position == gameObject.transform.position && !alreadyDone){
            canvas.SetActive(true);
            alreadyDone = true;
        }
    }
}
