using UnityEngine;

public class BrickPlayerController : MonoBehaviour
{
    Rigidbody2D playerRigidBody2D;
	[SerializeField] float moveSpeed = 10f;
	Vector2 startPosition;
	float direction;
	public bool isAlive = true;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		playerRigidBody2D = GetComponent<Rigidbody2D>();
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		if (isAlive == true)
		{
			PlayerControl();
		}
		playerRigidBody2D.linearVelocity = new Vector2(direction, 0) * moveSpeed;
	}

	void PlayerControl()
	{
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Keypad6))
		{
			direction = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Keypad8))
		{
			direction = 1f;
		}
		else
		{
			direction = 0;
		}
	}

	public void ResetPlayer(){
		transform.position = startPosition;
	}
}

