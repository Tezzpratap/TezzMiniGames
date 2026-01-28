using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager_SpaceInvaders : MonoBehaviour
{
    [SerializeField] int PlayerLives = 3;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform spawnTranform;
    [SerializeField] int playerSpawnDelay;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI lives;
    [SerializeField] GameObject WinPanel;
	[SerializeField] GameObject LoosePanel;
	[SerializeField] GameObject PausePanel;

	public bool isPlayerAlive = true;

    int playerScore = 0;

    private void Start()
    {
        UpdateUI();
    }

    public void AddScore(int points)
    {
        playerScore += points;
        UpdateUI();
    }

    void UpdateUI()
    {
        score.text = "Score: " + playerScore;
        lives.text = "Lives: " + PlayerLives;
    }

    public void PlayerDied()
    {
        PlayerLives--;
        isPlayerAlive = false;
        UpdateUI() ;
        if (PlayerLives <= 0)
        {
            LooseGame();
        }
        else
        {
            //Invoke(nameOf(RespawnPlayer()),playerSpawnDelay);
            RespawnPlayer();
        }
    }

    void RespawnPlayer()
    {
        Instantiate(playerPrefab, spawnTranform.position, Quaternion.identity);
        isPlayerAlive=true;
    }

    void LooseGame()
    {
        Debug.Log("LooseGame");
    }

    public void GameWin()
    {
        Debug.Log("Won");
    }

    public void ReloadGame(){
        SceneManager.LoadScene("Space Invaders");
    }
}
