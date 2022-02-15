using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 2, 3);
        //transform.position = new Vector3(3, 3, 3);

        //transform.Rotate(new Vector3(0, 0, 60f), Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3(Time.deltaTime, 0, 0);
        //Debug.Log(transform.position.magnitude);

        transform.Rotate(Vector3.up, Space.World);
    }
}
