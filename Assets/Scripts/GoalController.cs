using UnityEngine;
using TMPro;

public class GoalController : MonoBehaviour
{
    [SerializeField] bool isPlayer1;
    [SerializeField] BallController ballController;
    [SerializeField] GameManager gameManager;

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball")){
			//if the ball collides with the goal of player 1, player 2 scores
			if (isPlayer1 == false)
            {
                ballController.LaunchBall();
				gameManager.Player1Scored();
			}
            else
            {   
                ballController.LaunchBall();
				gameManager.Player2Scored();
			}
		}
        
	}
}
