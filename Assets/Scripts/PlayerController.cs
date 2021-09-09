using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityX = 5;
    public float jumpForce = 30;
    
    private Rigidbody2D rb;
    private Animator animator;
    // Start is called before the first frame update
    
    private const int ANIMATION_DEAD = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ZombieTrigger" )
        {
           Time.timeScale = 0;;
        }
    }
    
    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}















































































