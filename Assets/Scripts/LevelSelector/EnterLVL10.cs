using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLVL10 : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene(sceneName: "Level_10");
    }
}