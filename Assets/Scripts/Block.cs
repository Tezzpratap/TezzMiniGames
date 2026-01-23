using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] int health = 1;
	
	BrickGameManager gameManager;
	SpriteRenderer spriteRenderer;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindFirstObjectByType<BrickGameManager>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
        {
            health--;

			switch (health){
                case 0:{
					if(transform.parent.childCount <= 1)
					{
						gameManager.WinGame();
					}
					Destroy(gameObject);
					Debug.Log("Block destroyed");
					gameManager.AddScore(100);
					break;
			    }
                case 1:{
                    spriteRenderer.color = Color.green;
					gameManager.AddScore(80);
					break;
                }
                case 2:{
                    spriteRenderer.color = Color.yellow;
					gameManager.AddScore(50);
					break;
			    }
                case 3:{
                    spriteRenderer.color = Color.red;
					gameManager.AddScore(20);
					break;
				}
			}
         }
     }
}

