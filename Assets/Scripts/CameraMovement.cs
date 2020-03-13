
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    private int baseline = 3;
    public float smoothSpeed = 1f;
    public Vector3 offset;
    private GameObject spawnetObject;
    public Rigidbody spawnBody;

    private void Start()
    {
        //GameObject theSpawner = GameObject.Find("Spawner");
        //Spawner spawnerScript = theSpawner.GetComponent<Spawner>();
    }

    private void FixedUpdate()
    {
        if (Spawner.score > baseline)
        {
            baseline += 1;

            Vector3 desiredPosition = transform.position;
            desiredPosition.y += 1f;
            transform.position = desiredPosition;

            Vector2 spawnerPosition = spawnBody.position;
            spawnerPosition.y += 1;
            spawnBody.position = spawnerPosition;

        }
    }
}
