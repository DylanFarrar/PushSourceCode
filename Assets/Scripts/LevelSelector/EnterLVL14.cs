using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLVL14 : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene(sceneName: "Level_14");
    }
}