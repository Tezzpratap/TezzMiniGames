using UnityEngine;

public class BrickBallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D ballRigidBody2D;
    [SerializeField] float initialSpeed = 5f;

	BrickGameManager BrickGameManager;
	Vector2 startPosition;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		LaunchBall();
		BrickGameManager = FindFirstObjectByType<BrickGameManager>();
		startPosition = transform.position;
	}

	private void FixedUpdate()
	{
		ballRigidBody2D.linearVelocity = ballRigidBody2D.linearVelocity.normalized * initialSpeed;
	}

	public void LaunchBall()
	{
		transform.position = new Vector3(0,-4,0);

		float x = 0;
		int randomDirection = Random.Range(0, 2);

		if (randomDirection == 0)
		{
			x = 1f;
		}
		else if (randomDirection == 1)
		{
			x = -1f;
		}

		ballRigidBody2D.linearVelocity = new Vector2(x, 1f) * initialSpeed;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("KillBox"))
		{
			//Destroy(gameObject);
			Debug.Log("Died");
			BrickGameManager.playerDied();
		}
	}
}
