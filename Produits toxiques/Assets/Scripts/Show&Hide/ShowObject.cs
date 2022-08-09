using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowObject : MonoBehaviour
{
    public void Show(){
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
