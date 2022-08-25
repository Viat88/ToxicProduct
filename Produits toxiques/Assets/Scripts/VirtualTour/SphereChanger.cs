using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChanger : MonoBehaviour {



    public static SphereChanger current;
    //This object should be called 'Fader' and placed over the camera
    GameObject m_Fader;

    private float time = 0;
    public float transitionDelay;

    private bool changeSphere= false;
    private bool fadeInDone = false;
    private bool fadeOutDone = false;

    private bool cameraPositionChanged = false;

    private Transform nextSphere;


    void Awake()
    {
        // Check that it didn't already exist
        if (current == null)
        {
            current = this;
        }
        else
        {
            Destroy(obj: this);
        }
    

        //Find the fader object
        m_Fader = GameObject.Find("Fader");

        //Check if we found something
        if (m_Fader == null)
            Debug.LogWarning("No Fader object found on camera.");

    }

    void Update(){
        if (changeSphere){
            FadeCamera();
        }
    }

    public void StartChangingSphere(Transform sphere){
        nextSphere = sphere;

        if(HeadManager.current){
            HeadManager.current.Sphere = sphere;
        }
        

        changeSphere = true;                                    // We have to change sphere 
        fadeInDone = false;                                     // We haven't done fade in
        cameraPositionChanged = false;                          // We haven't change camera position
        fadeOutDone = false;                                    // We haven't done fade out
        time = 0;                                               // time is reset
    }

    private void FadeCamera(){

        // We get the material of the fader
        Material mat = m_Fader.GetComponent<Renderer>().material;

        // If we haven't already done the fade out
        if( !fadeInDone ){
            FadeIn(mat);
        }

        // If we have done the fade out
        else{

            // If we haven't wait, move camera and again wait
            if (time < transitionDelay){
                changeCameraPosition();
            }

            // Then when  it's done
            else{
                // We do the fade in
                if ( !fadeOutDone ){
                    FadeOut(mat);
                }

                else{
                    changeSphere = false;
                }
            }
        }
    }


    private void FadeOut(Material mat){
        
        mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, mat.color.a - (Time.deltaTime / 0.75f));

        if(mat.color.a <= 0.0f){
            fadeOutDone = true;
        }
    }


    private void FadeIn(Material mat){
        mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, mat.color.a + (Time.deltaTime / 0.75f));

        if(mat.color.a >= 1.0f){
            fadeInDone = true;
        }
    }

    private void changeCameraPosition(){

        time += Time.deltaTime;

        // We move camera when time = transitionDelay/2
        if (time >= transitionDelay/2 && !cameraPositionChanged){
            Camera.main.transform.parent.position = nextSphere.position;
            cameraPositionChanged = true;
        }
    }

}
