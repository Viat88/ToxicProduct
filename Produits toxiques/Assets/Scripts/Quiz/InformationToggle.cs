using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InformationToggle : MonoBehaviour
{
    public void SetPoste(){
        CertificateManager.current.SetPoste(gameObject.name);
    }
}
