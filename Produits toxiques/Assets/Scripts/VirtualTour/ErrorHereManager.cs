using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorHereManager : MonoBehaviour
{
    
    public List<GameObject> errorSphereList;                        // List of spheres containing an error
    private List<Vector3> errorSpherePositionList;                  // List of position of spheres containing an error
    public GameObject canva;                                        // Canva with message "error here"

///////////////////////// START FUNCTIONS ///////////////////////////////////

    void Start()
    {
        SetPositionList();                                          // We initialise errorSpherePositionList
    }

    void Update()
    {
        CheckSphere();                                              // We check if we are in a sphere containing an error
    }

///////////////////////////////////////////////////////////////////////////////

    /*
        Initialise errorSpherePositionList by taking position of each sphere in errorSphereList
    */
    private void SetPositionList(){                                 

        errorSpherePositionList = new List<Vector3>();

        foreach( GameObject g in errorSphereList){
            errorSpherePositionList.Add(g.transform.position);
        }
    }

    /*
        Show canva if we are in a sphere containing an error
    */
    private void CheckSphere(){
        if (IsAnErrorSphere()){
            ShowCanva(true);
        }
        else{
            ShowCanva(false);
        }
    }

    /*
        Check if we are currently in an error sphere 
        Output:
         -bool: true if we are in an error sphere, no otherwise
    */
    private bool IsAnErrorSphere(){
        return errorSpherePositionList.Contains(transform.position); 
    }

    private void ShowCanva(bool b){
        canva.SetActive(b);
    }

}
