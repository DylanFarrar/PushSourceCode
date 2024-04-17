using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class JumpsUI : MonoBehaviour
{
    TMP_Text textmeshPro;
    private PC PC;
    private float clicks;
    public GameObject player;

    void Start()
    {
        textmeshPro = GetComponent<TMP_Text>();

        textmeshPro.SetText("Jumps: {0} ", 0);
        //PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name));
    }

    void Update()
    {
        clicks = player.GetComponent<PC>().GetClicks();
        textmeshPro.SetText("Jumps: {0} ", clicks);
    }
}
