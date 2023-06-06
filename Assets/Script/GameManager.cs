using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public static float surviveTime;
    public static float best = 0;
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        surviveTime += Time.deltaTime;
        timeText.text = "Time: " + (int)surviveTime;
    }
}