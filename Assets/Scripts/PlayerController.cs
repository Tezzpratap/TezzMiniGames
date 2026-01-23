using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] bool isPlayer1 = true;
	[SerializeField] Rigidbody2D playerRigidBody2D;
    [SerializeField] float moveSpeed = 4f;
    float direction;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (isPlayer1 == true){
			Player1Control();
		}
		else{
			Player2Control();
		}
			

		playerRigidBody2D.linearVelocity = new Vector2(0, direction) * moveSpeed;
	}

    void Player1Control(){
		if (Input.GetKey(KeyCode.W))
		{
			direction = 1f;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			direction = -1f;
		}
		else
		{
			direction = 0;
		}
	}

	void Player2Control()
	{
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Keypad8))
		{
			direction = 1f;
		}
		else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Keypad2))
		{
			direction = -1f;
		}
		else
		{
			direction = 0;
		}
	}
}
