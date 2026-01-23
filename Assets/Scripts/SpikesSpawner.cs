using UnityEngine;

public class SpikesSpawner : MonoBehaviour
{
    [SerializeField] GameObject spikesPrefab;
    [SerializeField] float delayBetweenSpawns = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnSpikes), 0f, delayBetweenSpawns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSpikes(){
        Instantiate(spikesPrefab, transform.position, Quaternion.identity);
    }
}
