using UnityEngine;

public class spikes : MonoBehaviour
{ 
    [SerializeField] float height = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        Destroy(gameObject, 10f);
        float randomHeight = Random.Range(-height, height);
		transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }
}
