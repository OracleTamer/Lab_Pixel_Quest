using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private int variable3 = 3;
    string variable2 = "World";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string variable1 = "Hello ";

        Debug.Log(variable1 + variable2); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(variable3++);
        transform.position += new Vector3(0.005f, 0, 0);
       if (Input.GetKeyDown(KeyCode.W))
       {
            transform.position += new Vector3(0, 1, 0);
       }
    }
}
