using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeadManager : MonoBehaviour
{

    public static HeadManager current;           // Unique HeadManager
    public GameObject arrows;
    public GameObject canva;

///////////////////////// Listeners ///////////////////////////////////

    /*
        Listener about the number of error found
    */
    public event Action<int> OnNewErrorFound;
    public void NewErrorFound(int n){
        OnNewErrorFound?.Invoke(n);
    }

    [SerializeField]
    public int errorFound = 0;
    public int ErrorFound{
        get => errorFound;
        set
        {
            errorFound = value;
            NewErrorFound(errorFound); //Fire the event
        }
    }

///////////////////////// START FUNCTIONS ///////////////////////////////////

    void Awake() 
    {
        if (current == null)
        {
            current = this;
        }
        else
        {
            Destroy(obj: this);
        }
    }
    
    void Start()
    {}

    void Update()
    {}


    public void Activate7thError(){
        if (ErrorFound == 6){
            arrows.SetActive(true);
            canva.SetActive(true);
        }
    }
}
