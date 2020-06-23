using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    [SerializeField]
    private int items = 4;

    public int Items
    {
        get { return items; }
        set
        {
            
            items = value;
            inventory.Refresh();
        }
    }
    private Inventory inventory;

    [SerializeField]
    private float speed = 10.0F;
    [SerializeField]
    private float jumpForce = 30.0F;
    [SerializeField] public GameObject text;
    [SerializeField] public GameObject respawn;
    public Rigidbody2D rb;
    private bool isGrounded = false;
    float time = 5.0F;


    private CharState State
    {	
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    private Animator animator;
    private SpriteRenderer sprite;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
        
    }

    private void Update()
    {
        
        if (isGrounded) State = CharState.Idle;
        if (Input.GetButton("Horizontal")) Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();
        if (Input.GetKey(KeyCode.R)) transform.position = respawn.transform.position;
        if (text.activeSelf==true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                text.SetActive(false);
            }     
        }
    }

    private void Run()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            transform.localScale = new Vector2(-5, 6);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
	    transform.localScale = new Vector2(5, 6);
        }

        if (isGrounded)

        {
            State = CharState.Run;
            
        } 
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        GetComponent<AudioSource>().Play();
    }


    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.3F);

        isGrounded = colliders.Length > 1;

        if (!isGrounded) State = CharState.Jump;
    }
}


public enum CharState
{
    Idle,
    Run,
    Jump
}