using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject timeObject;
	public static GameManager instance;

	public GameObject gameOverUI;
	public GameObject scoreOverUI;
	public GameObject MeteorSpwanner;
	public bool isPaused = false;

	public GameObject pauseMenu;
	

	void Awake ()
	{
		instance = this;
		isPaused = true;

	}
	

	public void EndGame ()
	{
		UpdateHighscore();
		gameOverUI.SetActive(true);
		scoreOverUI.SetActive(false);
		MeteorSpwanner.SetActive(false);
		timeObject.SetActive(false);
	}

	public void Restart ()
	{
		SceneManager.LoadScene("New");
	}
	/*public void NetLevel()
	{
		gameObject.GetComponent<Planet>.Score() = 20f;
		SceneManager.LoadScene("Main");
		
	}*/
	public void MenuHome(){
		SceneManager.LoadScene("Menu");
	}
	public void pausegame()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
        isPaused = false;
        

        
        
       
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        isPaused = true;
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    private void UpdateHighscore()
    {
    	
    	float curHighScore = PlayerPrefs.GetInt("Highscore", 0);


    	if((int)Planet.Score <= curHighScore && curHighScore != 0)
    	
    	{
    		PlayerPrefs.SetInt("Highscore", (int)Planet.Score);
    	}
    	else
    	{
    		PlayerPrefs.SetInt("Highscore", (int)Planet.Score);	
    	}

    }
}
