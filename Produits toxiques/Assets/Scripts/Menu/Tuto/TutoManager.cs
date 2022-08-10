using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoManager : MonoBehaviour
{
    public static TutoManager current;
    private int step;


    private Quaternion initialQuaternion;
    public Camera mainCamera;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject canva3;
    public GameObject canva4;
    public List<GameObject> MenuItem;
    public GameObject redGaz;
    public List<GameObject> arrowsList;

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
    {
        initialQuaternion = mainCamera.transform.rotation;
        step = 0;
    }

    void Update()
    {
        ManageStep();
    }


///////////////////////////////////////////////////////////////////////////////

    private void ManageStep(){

        if (step == 1){

            EnableMenuItem(false);
            mainCamera.transform.rotation = initialQuaternion;
            EnableCameraMove(false);
            EnableCapsuleCollider(redGaz, true);

            Activate(canva1, true);
            step += 1;
        }

        if (step == 3){
            
            EnableCameraMove(true);
            EnableCapsuleCollider(redGaz, false);
            Activate(canva1, false);
            Activate(canva2, true);
            step += 1;
        }

        if (step == 4 && CameraTurned()){
            Activate(canva2, false);
            Activate(canva3, true);
            Activate(arrowsList[0], true);
            step += 1;
        }

        if (step == 6){
            Activate(canva3, false);
            Activate(canva4, true);

            Activate(arrowsList[0], false);
            Activate(arrowsList[1], true);

            step+=1;
        }

        if (step == 8){
            Activate(arrowsList[1], false);
            Activate(canva4, false);
            step = 0;
            EnableMenuItem(true);
            mainCamera.transform.rotation = initialQuaternion;
        }
    }


    private void EnableMenuItem( bool b ){

        foreach (GameObject g in MenuItem){
            EnableMeshCollider( g, b);
        }
        
    }

    private void EnableCameraMove(bool b){
        mainCamera.GetComponent<MouseView>().enabled = b;
    }

    private void EnableMeshCollider( GameObject g, bool b){
        g.GetComponent<MeshCollider>().enabled = b;
    }

    private void EnableCapsuleCollider( GameObject g, bool b){
        g.GetComponent<CapsuleCollider>().enabled = b;
    }

    private void Activate(GameObject g, bool b){
        g.SetActive(b);
    }


    private bool CameraTurned(){
        float rotation = mainCamera.transform.localEulerAngles.y;
        return rotation >= 70 && rotation <= 110;
    }

    public void StepPlusOne(){
        step += 1;
    }

}
