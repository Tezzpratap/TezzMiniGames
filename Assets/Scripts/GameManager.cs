using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int player1Score = 0;
    int player2Score = 0;

    [SerializeField] TextMeshProUGUI player1ScoreText;
	[SerializeField] TextMeshProUGUI player2ScoreText;

	public void Player1Scored()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
		Debug.Log("Player 1 Score: " + player1Score);
	}

    public void Player2Scored() {
        player2Score++;
		player2ScoreText.text = player2Score.ToString();
		Debug.Log("Player 2 Score: " + player2Score);
     }
}
