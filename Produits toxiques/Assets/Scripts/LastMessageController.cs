using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LastMessageController : MonoBehaviour
{
    private int score;
    public TMP_Text tmpText;

    void Start()
    {
        score = QuizManager.current.points;
    }

    void Update(){
        score = QuizManager.current.points;
        Settext();
    }

    private void Settext(){

        string newText;

        if (score <= 6){
            newText = "Aie, tu as obtenu le score de : " + score + "/10, tu devrais peu-être revoir les différentes erreurs et leurs explications";
        }

        else{
            if ( score <= 8){
                newText = "Super, tu as obtenu le score de : " + score + "/10, il ne reste qu'à revoir les quelques erreurs";
            }
            else{
                newText = "Bravo, tu as obtenu le score de : " + score + "/10, tu as parfaitement compris!";
            }
        }

        tmpText.text = newText;
    }
}
