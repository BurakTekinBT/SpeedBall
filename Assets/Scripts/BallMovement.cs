using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * ballSpeed;

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-0.216f, transform.position.y, transform.position.z);
    
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(0.216f, transform.position.y, transform.position.z);
        }

    }
}
