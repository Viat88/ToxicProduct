using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PathNumberController : MonoBehaviour
{

    public TMP_Text tmpText;

    void Start()
    {
        HeadManager.current.OnNewSphere += SetText;
    }

    private void SetText(Transform sphere){
        tmpText.text = CountArrows(sphere) + " chemins disponibles !";
    }


    private int CountArrows(Transform sphere){

        int numberOfArrows = 0;

        for(int i=0; i<sphere.childCount; i++){

            Transform child = sphere.GetChild(i);
            if (child.CompareTag("Arrow")){
                numberOfArrows += 1;
            }
        }

        return numberOfArrows;

    }
}
