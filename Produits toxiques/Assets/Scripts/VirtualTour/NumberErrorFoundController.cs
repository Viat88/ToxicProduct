using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberErrorFoundController : MonoBehaviour
{

    public TMP_Text tmpText;

    void Start()
    {
        HeadManager.current.OnNewErrorFound += SetText;
    }

    private void SetText(int n){
        tmpText.text = n + "/7";
    }
}
