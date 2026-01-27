using UnityEngine;

public class EnemySpaceShip : MonoBehaviour
{
    [SerializeField] EnemySpaceShipManager enemySpaceShipManager;
    [SerializeField] GameManager_SpaceInvaders SpaceInvaders_gameManager;
    [SerializeField] GameObject LaserPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Fire", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Fire()
    {
        if (Random.value < (1f / transform.parent.childCount))
        {
            Instantiate(LaserPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            if (transform.parent.childCount <= 1)
            {
                SpaceInvaders_gameManager.GameWin();
            }
            Destroy(collision.gameObject); //Will destroy bullet
            Destroy(gameObject); // will destroy spaceship self
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            enemySpaceShipManager.ChangeDirecion();
        }
    }
}
