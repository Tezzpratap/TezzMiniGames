using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BrickGameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] int lives = 3;

	[SerializeField] BrickBallController BrickBallController;
	[SerializeField] BrickPlayerController BrickPlayerController;

	[SerializeField] TextMeshProUGUI scoreText;
	[SerializeField] GameObject WinPanel;
	[SerializeField] GameObject LoosePanel;
	[SerializeField] GameObject PausePanel;

	public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
		scoreText.text = score.ToString();
	}

    public void playerDied(){
        lives--;

        if (lives <= 0){
			GameOver();
		}else{
			Debug.Log("Lives: " + lives);
			Debug.Log("Respawning Player");
			ResetBall();
			BrickBallController.LaunchBall();
		}
	}

	void GameOver(){
		LoosePanel.SetActive(true);
		BrickPlayerController.isAlive = false;
	}

	public void WinGame()
	{
		WinPanel.SetActive(true);
	}
	
	void ResetBall()
	{
		BrickBallController.LaunchBall();
		BrickPlayerController.ResetPlayer();
	}

	public void LoadScene(){
		SceneManager.LoadScene("BreakingBricks");
	}
}
