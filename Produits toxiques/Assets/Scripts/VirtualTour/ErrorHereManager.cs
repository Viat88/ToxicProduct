using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorHereManager : MonoBehaviour
{
    public List<GameObject> errorSphereList;
    private List<Vector3> errorSpherePositionList;
    public GameObject canva;

///////////////////////// START FUNCTIONS ///////////////////////////////////

    void Start()
    {
        SetPositionList();
    }

    void Update()
    {
        CheckSphere();
    }

///////////////////////////////////////////////////////////////////////////////

    private void SetPositionList(){

        errorSpherePositionList = new List<Vector3>();

        foreach( GameObject g in errorSphereList){
            errorSpherePositionList.Add(g.transform.position);
        }
    }


    private void CheckSphere(){
        if (IsAnErrorSphere()){
            ShowCanva(true);
        }
        else{
            ShowCanva(false);
        }
    }


    private bool IsAnErrorSphere(){
        return errorSpherePositionList.Contains(transform.position); 
    }

    private void ShowCanva(bool b){
        canva.SetActive(b);
    }

}
