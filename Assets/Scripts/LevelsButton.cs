using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButton : MonoBehaviour
{

    public void OnClick(){
        Debug.Log("it worked again");
        SceneManager.LoadScene(sceneName: "LevelsMenu");
    }
}
