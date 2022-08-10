using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationInputField : MonoBehaviour
{

    public void ReadStringInput(string s){
        
        if(name == "Surname"){
            CertificateManager.current.SetSurname(s);
        }
        if(name == "Name"){
            CertificateManager.current.SetName(s);
        }
        if(name == "Service"){
            CertificateManager.current.SetService(s);
        }
    }
}
