using UnityEngine;

public class FlappyBirdController : MonoBehaviour
{
    float coolDown = 0.1f;
    float counter = 0;

    Rigidbody2D flappyRigidbody2D;
    [SerializeField] float thrust;
    [SerializeField] FlappyBirdGameManager flappyGameManager;
    [SerializeField] FlappyScore score;

    void Awake(){
        flappyRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space)) && counter > coolDown){
			flappyRigidbody2D.linearVelocity = Vector2.zero;
            flappyRigidbody2D.AddForce(Vector2.up * thrust, ForceMode2D.Impulse);
            counter = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Spikes") || collision.gameObject.CompareTag("Ground")){
            flappyGameManager.GameOver();
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("FlappyPoints"))
		{
            score.AddPoints();
		}
	}
}
