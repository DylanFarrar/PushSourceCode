using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarsCheck : MonoBehaviour
{
    public float Level_1;
    public float Level_2;
    public float Level_3;
    public float Level_4;
    public float Level_5;
    public float Level_6;
    public float Level_7;
    public float Level_8;
    public float Level_9;
    public float Level_10;
    public float Level_11;
    public float Level_12;
    public float Level_13;
    public float Level_14;
    public float Level_15;
    public float Level_16;

    public void starsCheck(float clicks){
        string scene = SceneManager.GetActiveScene().name;
        float current = PlayerPrefs.GetFloat(scene);

        if(current == 0){
            PlayerPrefs.SetFloat(scene, 1);
        }
        else{

            switch (scene){

                case "Level_1":
                    if(clicks <= Level_1){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_2":
                    if(clicks <= Level_2){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_3":
                    if(clicks <= Level_3){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_4":
                    if(clicks <= Level_4){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_5":
                    if(clicks <= Level_5){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_6":
                    if(clicks <= Level_6){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_7":
                    if(clicks <= Level_7){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_8":
                    if(clicks <= Level_8){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_9":
                    if(clicks <= Level_9){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_10":
                    if(clicks <= Level_10){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_11":
                    if(clicks <= Level_11){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_12":
                    if(clicks <= Level_12){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_13":
                    if(clicks <= Level_13){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_14":
                    if(clicks <= Level_14){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_15":
                    if(clicks <= Level_15){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;

                case "Level_16":
                    if(clicks <= Level_16){
                        PlayerPrefs.SetFloat(scene, 2);
                    }
                break;
            }
        }
    }
}
