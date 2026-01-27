using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float laserSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyLaser"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
