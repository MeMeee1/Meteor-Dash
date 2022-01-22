using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highy : MonoBehaviour
{
    public static Highy instance;

    public Text nameField;

    public void Awake()
    {
        instance = this;
    }

    public void SubmitScore()
    {
        HighScores.UploadScore(nameField.text, PlayerPrefs.GetInt("Highscore", 0));
    }
}
