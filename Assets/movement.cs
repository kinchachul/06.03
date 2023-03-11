using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public int upForce = 300 ;
    public float speed = 1500;
    public float runSpeed = 3000;
    public bool isGrounded = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        { 
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, rb.velocity.y);
        }
        else
        {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, rb.velocity.y);
        }


        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            rb.AddForce(Vector2.up * upForce);
            isGrounded = false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("11.03");
    }


    

}
