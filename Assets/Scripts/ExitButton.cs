using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void OnClick(){
        Debug.Log("it worked");
        Application.Quit();
    }
}
