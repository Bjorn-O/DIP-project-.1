using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody[] cubes;
    public Rigidbody laserBody;

    public Transform laserPointer;
    public Transform[] locations;
    
    private int activeCube = 0;
    static public int score = 0;
    public bool raycastActive = true;

    private void Start()
    {
        Instantiate(cubes[0], locations[0]);
    }

    public void SpawnBlock()
    {
        Debug.Log("Hey sexy lade");
        int i = Random.Range(0, locations.Length);
        Instantiate(cubes[activeCube], locations[i]);
    }

    private void Update()
    {
        switch (score)
        {
            case 32:
                activeCube = 6;
                break;
            case 24:
                activeCube = 5;
                break;
            case 16:
                activeCube = 4;
                break;
            case 12:
                activeCube = 3;
                break;
            case 8:
                activeCube = 2;
                break;
            case 4:
                activeCube = 1;
                break;
        }
    }
    

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(laserPointer.position, transform.TransformDirection(Vector3.right), out hit) && raycastActive == true)
        {
            raycastActive = false;

            Vector2 laserPosition = laserBody.position;

            laserPosition.y += 1;

            score += 1;

            SpawnBlock();

            laserBody.position = laserPosition;

            raycastActive = true;
        }

    }
}
