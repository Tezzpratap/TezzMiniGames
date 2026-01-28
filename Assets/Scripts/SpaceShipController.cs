using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    float spaceShipSpeed = 8f;
    float counter = 0f;

    const float MIN_X = -8f;
    const float MAX_X = 8f;
    const float MIN_Y = -4f;
    const float MAX_Y = 4f;

    [SerializeField] GameObject Laser;
    GameManager_SpaceInvaders gameManager_SpaceInvaders;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager_SpaceInvaders = FindFirstObjectByType<GameManager_SpaceInvaders>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionH = Input.GetAxisRaw("Horizontal");
        float directionV = Input.GetAxisRaw("Vertical");
        transform.position += Vector3.right * directionH * spaceShipSpeed * Time.deltaTime;
        transform.position += Vector3.up * directionV * spaceShipSpeed * Time.deltaTime;

        float clampedX = Mathf.Clamp(transform.position.x, MIN_X, MAX_X);
        float clampedY = Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y);
        transform.position = new Vector3(clampedX, clampedY, 0);

        counter += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && counter > 0.5f)
        {
            Instantiate(Laser, transform.position, Quaternion.identity);
            counter = 0f;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyLaser"))
        {
            gameManager_SpaceInvaders.PlayerDied();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
