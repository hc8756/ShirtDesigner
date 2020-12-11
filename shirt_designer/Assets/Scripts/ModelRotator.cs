using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotator : MonoBehaviour
{
    public KeyCode pressRight;
    public KeyCode pressLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(pressLeft)) {
            transform.Rotate(0.0f,1.0f ,0.0f , Space.Self);
        }

        if (Input.GetKey(pressRight))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);
        }

    }
}
