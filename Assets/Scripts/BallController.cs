using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D ballRigidBody2D;
    [SerializeField] float initialSpeed = 20;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		LaunchBall();
    }

	public void LaunchBall()
	{
		transform.position = Vector3.zero;

		float x = 0;
		float y = 0;
		int randomDirection = Random.Range(0, 4);

		if (randomDirection == 0)
		{
			x = 1;
			y = 1;
		}
		else if (randomDirection == 1)
		{
			x = 1;
			y = -1;
		}
		else if (randomDirection == 2)
		{
			x = -1;
			y = 1;
		}
		else if (randomDirection == 3)
		{
			x = -1;
			y = -1;
		}

		ballRigidBody2D.linearVelocity = new Vector2(x, y) * initialSpeed;
	}
}
