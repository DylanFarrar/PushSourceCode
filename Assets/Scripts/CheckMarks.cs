using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarks : MonoBehaviour
{
    public GameObject button;
    public float status;
    public SpriteRenderer sprite;

    void Start(){

        status = PlayerPrefs.GetFloat(button.name);

        if(status == 1){
            sprite.sortingOrder = 2;
        }
    }
}
