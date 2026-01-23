using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
	[Header("Landing Page UI")]
	public GameObject gamePanel;       // Panel with game buttons
	public Button playButton;
	public Button exitButton;

	[Header("Pause Menu UI")]
	public GameObject pauseMenu;

	private bool isPaused = false;

	void Start()
	{
		// Ensure panels are hidden initially
		if (gamePanel != null) gamePanel.SetActive(false);
		if (pauseMenu != null) pauseMenu.SetActive(false);

		// Hook up button events if they exist
		if (playButton != null) playButton.onClick.AddListener(OpenGamePanel);
		if (exitButton != null) exitButton.onClick.AddListener(ExitGame);
	}

	void Update()
	{
		// Toggle pause menu with ESC
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (!isPaused)
				PauseGame();
			else
				ResumeGame();
		}
	}

	// === Landing Page Functions ===
	public void OpenGamePanel()
	{
		if (gamePanel != null)
			gamePanel.SetActive(true);
	}

	public void ExitGame()
	{
		Application.Quit();
		Debug.Log("Game Quit!"); // Works only in build, not editor
	}

	// === Game Scene Functions ===
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
		Time.timeScale = 1f;
	}

	// === Pause Menu Functions ===
	public void PauseGame()
	{
		if (pauseMenu != null)
			pauseMenu.SetActive(true);

		Time.timeScale = 0f; // Freeze game
		isPaused = true;
	}

	public void ResumeGame()
	{
		if (pauseMenu != null)
			pauseMenu.SetActive(false);

		Time.timeScale = 1f; // Resume game
		isPaused = false;
	}

	public void ReturnToLandingPage()
	{
		Time.timeScale = 1f; // Ensure time resumes
		SceneManager.LoadScene("LandingPage"); // Replace with your landing scene name
	}

	public void MainMenuGame()
	{
		SceneManager.LoadScene("LandingPage");
	}
}
