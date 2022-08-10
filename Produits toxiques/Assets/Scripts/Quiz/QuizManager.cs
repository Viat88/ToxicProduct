using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public static QuizManager current;
    private int step = 0;
    public int points =0;

    private bool a;
    private bool b;
    private bool c;

    private List<List<bool>> correctionList = new List<List<bool>>();


///////////////////////////////////////////////////////////////////////////////

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
        ResetResponses();
        SetListCorrection();
    }

///////////////////////////////////////////////////////////////////////////////

    public void Selected(string x){

        if (x == "a"){
            a = !a;
        }

        if (x == "b"){
            b = !b;
        }

        if (x == "c"){
            c = !c;
        }
    }

    public void Validate(){

        if (IsCorrect()){
            points += 1;
        }

        step += 1;
        ResetResponses();
    }

    public bool IsCorrect(){

        List<bool> correction = correctionList[step];
        bool correct = true;

        if (a != correction[0]){
            correct = false;
        }

        if (b != correction[1]){
            correct = false;
        }

        if (c != correction[2]){
            correct = false;
        }
        
        return correct;
    }

    public void Restart(){
        ResetResponses();
        step = 0;
        points = 0;
    }

///////////////////////////////////////////////////////////////////////////////

    private void ResetResponses(){
        a = false;
        b = false;
        c = false;
    }


    private void SetListCorrection(){

        correctionList.Add(SetCorrection(true, true, false));           //1
        correctionList.Add(SetCorrection(false, false, true));          //2
        correctionList.Add(SetCorrection(false, false, true));          //3
        correctionList.Add(SetCorrection(false, true, false));          //4
        correctionList.Add(SetCorrection(false, true, false));          //5
        correctionList.Add(SetCorrection(false, false, true));          //6
        correctionList.Add(SetCorrection(false, true, false));          //7
        correctionList.Add(SetCorrection(false, true, false));          //8
        correctionList.Add(SetCorrection(true, false, true));           //9
        correctionList.Add(SetCorrection(false, false, true));          //10
    }

    private List<bool> SetCorrection(bool b1, bool b2, bool b3){
        List<bool> correction = new List<bool>();
        correction.Add(b1);
        correction.Add(b2);
        correction.Add(b3);
        return correction;
    }
}
