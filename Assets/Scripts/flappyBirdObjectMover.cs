using UnityEngine;

public class flappyBirdObjectMover : MonoBehaviour
{
    [SerializeField] float groundMoveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
		transform.position += Vector3.left * Time.deltaTime * groundMoveSpeed;
	}
}
