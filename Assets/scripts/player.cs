using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    [SerializeField]

    private float moveforce = 10f;

    [SerializeField]
    private float jumpforce = 11f;


    //[SerializeField] private Camera maincamera;
    //[SerializeField] private Vector3 temp;
    private float movementx;

    private Rigidbody2D mybody;

    private SpriteRenderer sr;


    private Animator anim;
    public string walk_animation = "walk";

    private bool isgrounded = true;

    private string groung_tag = "ground";

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }




    // Start is called before the first frame update
    void Start()
    {
        //maincamera.transform.position=new Vector3(2.5f, -0.01f, -1f);


    }

    // Update is called once per frame
    void Update()

    {


        playermovekeyboard();
        animateplayer();
        // temp.x= gameObject.transform.position.x;
        // maincamera.transform.position = temp;
    }

    private void FixedUpdate()
    {
        playerJump();
    }
    void playermovekeyboard()
    {
        movementx = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementx, 0f, 0f) * moveforce * Time.deltaTime;


    }
    void animateplayer()
    {

        if (movementx > 0)
        {
            anim.SetBool(walk_animation, true);
            sr.flipX = false;
        }
        else if (movementx < 0)
        {
            anim.SetBool(walk_animation, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(walk_animation, false);
        }
    }

    void playerJump()
    {
        if (Input.GetButton("Jump") && isgrounded)
        {
            isgrounded = false;


            mybody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(groung_tag))
        {

            isgrounded = true;
        }
    }



}



















//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player : MonoBehaviour
//{

//    [SerializeField]
//    private float moveForce = 10f;

//    [SerializeField]
//    private float jumpForce = 11f;

//    private float movementX;

//    private Rigidbody2D myBody;

//    private SpriteRenderer sr;

//    private Animator anim;
//    private string WALK_ANIMATION = "Walk";

//    private bool isGrounded;
//    private string GROUND_TAG = "Ground";

//    private string ENEMY_TAG = "Enemy";

//    private void Awake()
//    {

//        myBody = GetComponent<Rigidbody2D>();
//        anim = GetComponent<Animator>();

//        sr = GetComponent<SpriteRenderer>();

//    }

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        PlayerMoveKeyboard();
//        AnimatePlayer();

//    }

//    private void FixedUpdate()
//    {
//        PlayerJump();
//    }

//    void PlayerMoveKeyboard()
//    {

//        movementX = Input.GetAxisRaw("Horizontal");

//        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;

//    }

//    void AnimatePlayer()
//    {

//        // we are going to the right side
//        if (movementX > 0)
//        {
//            anim.SetBool(WALK_ANIMATION, true);
//            sr.flipX = false;
//        }
//        else if (movementX < 0)
//        {
//            // we are going to the left side
//            anim.SetBool(WALK_ANIMATION, true);
//            sr.flipX = true;
//        }
//        else
//        {
//            anim.SetBool(WALK_ANIMATION, false);
//        }

//    }

//    void PlayerJump()
//    {

//        if (Input.GetButtonDown("Jump") && isGrounded)
//        {
//            isGrounded = false;
//            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
//        }

//    }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {

//        if (collision.gameObject.CompareTag(GROUND_TAG))
//            isGrounded = true;


//        if (collision.gameObject.CompareTag(ENEMY_TAG))
//            Destroy(gameObject);


//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.CompareTag(ENEMY_TAG))
//            Destroy(gameObject);
//    }

//} // class






























