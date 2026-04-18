using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{   
    private int variable3 = 3;
    string variable2 = "World";
    private SpriteRenderer playerRenderer;
    private Rigidbody2D rb;
    public string NextLevel = "Level 2";
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string variable1 = "Hello ";
        playerRenderer = GetComponent<SpriteRenderer>(); 
        Debug.Log(variable1 + variable2);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
      
        // Player movement
        float XInput = Input.GetAxis("Horizontal");
        //Debug.Log(XInput);
        rb.velocity = new Vector2(XInput * speed, rb.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        */
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerRenderer.material.color = new Color32(255, 0, 0, 255);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerRenderer.material.color = new Color32(0, 255, 0, 255);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerRenderer.material.color = new Color32(0, 0, 255, 255);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Coin":
                {
                    Destroy(collision.gameObject);
                    Debug.Log("Coin Got!");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(NextLevel);
                    break;
                }
        }
    }

    

}   

