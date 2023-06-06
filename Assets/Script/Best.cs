using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best : MonoBehaviour
{
    public Text recordText;
    // Start is called before the first frame update
    void Start()
    {
        recordText.text = "Best: " + GameManager.best;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
