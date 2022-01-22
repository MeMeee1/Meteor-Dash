using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text fpsDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update() {
        var fps = 1 / Time.unscaledDeltaTime;
        fpsDisplay.text = "" + fps;
}
}
