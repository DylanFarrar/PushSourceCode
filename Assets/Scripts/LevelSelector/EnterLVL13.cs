using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLVL13 : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene(sceneName: "Level_13");
    }
}