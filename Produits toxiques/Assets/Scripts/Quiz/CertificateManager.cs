using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class CertificateManager : MonoBehaviour
{
    public static CertificateManager current;

    private string surname = "Unknown";
    private string playerName = "Unknown";
    private string service = "Unknown";
    private string poste = "CDI";
    private System.DateTime date;
    private int score = 0;

    private string docName;




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

///////////////////////////////////////////////////////////////////////////////

    public void PrintDocument(){
        Debug.Log("Le fichier a été créé");

        SetDocName();
        SetDate();

        System.IO.File.WriteAllText(docName, "<!DOCTYPE html>\n<html>\n<body>\n<img src=LogoSchneider.jpg>\n<p>Nom:" + surname + "</p>\n<p>Prenom:" + playerName + "</p>\n<p>Service:" + service + "</p>\n<p>Date:" + date + "</p>\n<p>Poste:" + poste + "</p>\n<p>A obtenu la note de " + score + "/10 au quiz sur les substances chimiques<p>\n</body>\n</html>");
    }

///////////////////////////////////////////////////////////////////////////////

    private void SetDocName(){
        docName = "certificat" + surname + playerName + ".html";
    }

    private void SetDate(){
        date = System.DateTime.Now;
    }

///////////////////////////////////////////////////////////////////////////////
    public void SetPoste(string s){
        poste = s;
    }

    public void SetSurname(string s){
        surname = s.ToUpper();
    }

    public void SetName(string s){
        playerName = s.ToLower();
    }

    public void SetService(string s){
        service = s;
    }

    public void SetScore(int n){
        score = n;
    }
}
