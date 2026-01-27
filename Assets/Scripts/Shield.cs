using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] float health = 3;

    SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser") || collision.gameObject.CompareTag("EnemyLaser"))
        {
            health--;
            Destroy(collision.gameObject); //will destroy laser aslo
            if (health == 2)
            {
                spriteRenderer.color = Color.yellow;
            }
            else if (health == 1)
            {
                spriteRenderer.color = Color.red;
            }
            else if (health <= 0)
            {
                Destroy(gameObject); //will destroy self
            }
        }
    }
}
