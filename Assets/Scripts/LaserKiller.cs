using UnityEngine;

public class LaserKiller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser") || collision.gameObject.CompareTag("EnemyLaser"))
        {
            Destroy(collision.gameObject);
        }
    }
}
