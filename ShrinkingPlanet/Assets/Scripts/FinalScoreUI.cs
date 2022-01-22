using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
		GetComponent<Text>().text = "<b>d</b> = <i><b>" + Planet.Score.ToString("0.#") + "m</b></i>";
		//gameObject.GetComponent<Timer>().UpdateTimerUI().text = "<b>HIGHSCORE</b> = <i><b>" + timerText;

	}

}
