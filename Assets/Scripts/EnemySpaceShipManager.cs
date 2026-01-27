using UnityEngine;

public class EnemySpaceShipManager : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] GameManager_SpaceInvaders GameManager_SpaceInvaders;

    Vector3 direction = Vector3.right;
    float counter = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager_SpaceInvaders.isPlayerAlive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        counter += Time.deltaTime;
    }

    public void ChangeDirecion()
    {
        if (counter > 0.5f) {
            direction *= -1f;
            counter = 0f;
        }
    }
}
