using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLVL3 : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene(sceneName: "Level_3");
    }
}