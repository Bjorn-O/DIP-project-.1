
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private bool isFalling = true;
    public float speed = 0.46f;
    public GameObject cube;
    public Transform location;

    // Update is called once per frame
    void Update()
    {
        Vector2 cubePosition = transform.position;
        if (isFalling == true)
        {
            if (Input.GetKeyDown("left") && transform.position.x != -2.3f)
                {
                cubePosition.x -= speed;
                Debug.Log("Left.");
                }
            if (Input.GetKeyDown("right") && transform.position.x != 2.3f)
            {
                cubePosition.x += speed;
                Debug.Log("Right.");
            }
        }
        transform.position = cubePosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        isFalling = false;
        Debug.Log("p");
        // Function from another .cs, perhaps this changes a variable that triggers an if-statement in another script.
    }
}
