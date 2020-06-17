using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Horizontal Movement")]
    public float moveSpeed;
    public Vector2 direction;
    public float turnTime;

    [Header("Jumping")]
    public float jumpSpeed;
    public float fallMultiplier;
    public float defGravity;

    [Header("Abilities")]
    public float moveForgiveness;
    public float attackCooldown;
    public GameObject lightProjectilePrefab;
    public float lightProjectileForce;
    public float lightProjectileRange;
    public enum Combo
    {
        NO_MOVE,
        LIGHT_ATTACK,
        LIGHT_ATTACK2,
        TRIPLE_SLASH,
        PARRY,
        HEAVY_SLASH,
    };
    public Dictionary<Combo, float> attackCooldowns;
    public Combo lastMove = Combo.NO_MOVE;
    public bool isAttacking;
    private float attack;
    private float sinceAttack;
    private bool canAttack;

    [Header("Components")]
    public Rigidbody2D rb;
    public Animator animator;
    public Transform graphicsHolder;
    public GameObject slashSprite;
    public AudioSource aPlayer;
    public LayerMask groundLayer;

    [Header("Collision")]
    public bool onGround = false;
    public float groundDistance;

    private float movementDirection;
    private bool orientation = true;
    private float sinceJump;
    private float sinceFall;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        aPlayer = GetComponent<AudioSource>();
        attackCooldowns = new Dictionary<Combo, float>();
        attackCooldowns.Add(Combo.LIGHT_ATTACK, attack);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistance);
    }

    private void Update()
    {
        bool wasOnGround = onGround;
        onGround = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);
        if (onGround != wasOnGround)
        {
            sinceFall = moveForgiveness;
        }
        HandleJump();
        if (onGround)
        {
            animator.SetBool("jumpUp", false);
            animator.SetBool("jumpDown", false);
        }
        else if (!animator.GetBool("jumpUp"))
        {
            animator.SetBool("jumpUp", true);
            animator.SetBool("jumpDown", true);
        }
        if (Input.GetButton("Horizontal") && direction.x != 0)
        {
            movementDirection = direction.x;
        }
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveCharacter(direction.x);

        HandleAttacks();
    }

    private void FixedUpdate()
    {
        
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        animator.SetBool("jumpUp", true);
    }

    void HandleJump()
    {
        if (sinceJump > 0)
        {
            sinceJump -= Time.deltaTime;
        }
        if (sinceFall > 0)
        {
            sinceFall -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump"))
        {
            sinceJump = moveForgiveness;
        }
        if (!onGround)
        {
            rb.gravityScale = defGravity;
            if (rb.velocity.y < 0)
            {
                rb.gravityScale = fallMultiplier;
                animator.SetBool("jumpDown", true);
            } else if(rb.velocity.y > 0)
            {
                if (!Input.GetButton("Jump"))
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                    rb.gravityScale = defGravity * fallMultiplier / 2;
                    animator.SetBool("jumpDown", true);
                }
            }
        }
        if (sinceJump > 0 && (onGround || sinceFall > 0))
        {
            Jump();
        }
    }

    void MoveCharacter(float horizontal)
    {
        rb.velocity = new Vector2(Vector2.right.x * horizontal * moveSpeed, rb.velocity.y);
        if (rb.velocity.x != 0)
        {
            animator.SetBool("Running", true);
        } else
        {
            animator.SetBool("Running", false);
        }
        if ((horizontal > 0 && !orientation) || (horizontal < 0 && orientation))
        {
            Flip();
        }
    }

    void Flip()
    {
        orientation = !orientation;
        animator.SetBool("isTurning", true);
        StartCoroutine("FlipTimer");
    }

    public IEnumerator FlipTimer()
    {
        yield return new WaitForSeconds(turnTime);
        transform.rotation = Quaternion.Euler(0, orientation ? 0 : 180, 0);
        animator.SetBool("isTurning", false);

    }

    void HandleAttacks()
    {
        animator.SetBool("Attack", false);
        if (sinceAttack <= 0)
        {
            canAttack = true;
        }
        else
        {
            sinceAttack -= Time.deltaTime;
            if (attackCooldown - moveForgiveness > sinceAttack)
            {
                slashSprite.SetActive(false);
                isAttacking = false;
            }
        }
        if (Input.GetAxisRaw("Fire1") != 0)
        {
            attack = moveForgiveness;
        }
        if (attack > 0 && canAttack)
        {
            PerformAttack();
        } else if(attack > -moveForgiveness)
        {
            attack -= Time.deltaTime;
        } else
        {
            lastMove = Combo.NO_MOVE;
        }
    }

    void PerformAttack()
    {
        canAttack = false;
        isAttacking = true;
        sinceAttack = attackCooldown;
        animator.SetBool("Attack", true);
        //slashSprite.SetActive(true);
        //slashSprite.GetComponent<Collider2D>().enabled = true;
        Vector3 projDirection = new Vector3(movementDirection, 0f, 0f);
        GameObject proj = Instantiate(lightProjectilePrefab, transform.position + projDirection.normalized * 1f, Quaternion.identity);
        proj.GetComponent<Rigidbody2D>().AddForce(projDirection.normalized * lightProjectileForce, ForceMode2D.Impulse);
        proj.transform.rotation = Quaternion.Euler(0, orientation ? 0 : 180, 0);
        proj.GetComponent<Fireball>().DestroyOffset(lightProjectileRange);
        aPlayer.Play();
        if (lastMove == Combo.NO_MOVE)
        {
            lastMove = Combo.LIGHT_ATTACK;
        }
    }

}
