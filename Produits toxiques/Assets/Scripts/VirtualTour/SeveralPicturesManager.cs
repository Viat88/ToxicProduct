using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeveralPicturesManager : MonoBehaviour
{
    
    [Header ("Pictures")]
    public List<GameObject> listPicture;

    [Header ("Texts")]
    public List<GameObject> listText;


    public void Click(int n){

        listText[n].SetActive(!listText[n].activeSelf);
        listPicture[n].SetActive(listText[n].activeSelf);

        int other = (n+1)%2;
        
        if (listText[n].activeSelf){
            listPicture[other].SetActive(false);
        }

        else{
            listPicture[other].SetActive(listText[other].activeSelf);
        }
    }
}
