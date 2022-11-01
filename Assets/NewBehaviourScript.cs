using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");
        //print("tranform.position");

        if (Input.GetKeyDown(KeyCode.W))
        {
            //print("Hello");

            //transform.position = new Vector3(2, 5, 2);

            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, 2);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            //transform.position = new Vector3(2, 5, 2);

            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, 2);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.position = new Vector3(2, 1, 2);

            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, 2);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            //transform.position = new Vector3(2, 1, 2);

            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, 2);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.position = new Vector3(4, 3, 2);

            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, 2);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            //transform.position = new Vector3(4, 3, 2);

            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, 2);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.position = new Vector3(0, 3, 2);

            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, 2);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            //transform.position = new Vector3(0, 3, 2);

            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, 2);
        }
    }
}
