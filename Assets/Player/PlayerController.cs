using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    //private AudioSource source;
   

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //source = GetComponent<AudioSource>();

        moveSpeed = 3f;
        jumpForce = 70f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));
        moveVertical = Input.GetAxisRaw("Vertical");
      
      /*  
        if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D)))
        {
            source.Play();
        }
       
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || isJumping)
        {
            source.Stop();
        }
      */

    }

    private void FixedUpdate()
    {
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb2D.AddForce(new Vector2 (moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
         
            isJumping = true;
            animator.SetBool("Jumping", true);
        }

        if(moveHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3 ((float)0.5864107, (float)0.6584303, 1);
            //gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        if (moveHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3 ((float)-0.5864107, (float)0.6584303, 1);
            //gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
            animator.SetBool("Jumping", false);
        }

    }

}
