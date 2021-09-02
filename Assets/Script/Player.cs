using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject self;
    public Rigidbody2D rb;
    public bool Left = false;
    public bool Right = false;
    public bool UP = false;
    public bool Down = false;
    public bool Space = false;
    public bool IsGround = false;
    public bool Controled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controled)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Space = true;
            }
        }
    }
    void FixedUpdate()
    {
        if (Controled)
        {
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                self.transform.position = new Vector3(self.transform.position.x + 0.1f, self.transform.position.y, self.transform.position.z);
                self.transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            }
            else if (Input.GetAxisRaw("Horizontal") == -1)
            {
                if (self.transform.position.x < -21.9f)
                {
                    self.transform.position = new Vector3(-22f, self.transform.position.y, self.transform.position.z);
                }
                else
                {
                    self.transform.position = new Vector3(self.transform.position.x - 0.1f, self.transform.position.y, self.transform.position.z);
                }
                
                self.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                
            }
            if (Space)
            {
                Space = false;
                if (IsGround)
                {
                    IsGround = false;
                    rb.AddForce(new Vector2(0, 300));
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col2D)
    {
        IsGround = true;
    }
    void OnCollisionExit2D(Collision2D col2D)
    {
        IsGround = false;
    }
}
