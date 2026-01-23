using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdGameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
	[SerializeField] GameObject gamePausePanel;

	public void GameOver(){
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }

    public void FlappyPause(){
        if (Input.GetKey(KeyCode.Escape)){
            gamePausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ReloadGame(){
        SceneManager.LoadScene("FlappyBird");
		Time.timeScale = 1f;
	}

    public void MainMenuGame(){
        SceneManager.LoadScene("LandingPage");
    }

    public void Exit(){
        Application.Quit();
        Debug.Log("Game Mode Exit");
    }
}
