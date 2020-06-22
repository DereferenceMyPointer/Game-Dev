using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{

    public float animationTime;

    public void Dash(Animator animator, float dashSpeed, Rigidbody2D rb, PlayerMovement p)
    {
        StartCoroutine(Perform(animator, dashSpeed, rb, p));
    }

    public IEnumerator Perform(Animator animator, float speed, Rigidbody2D rb, PlayerMovement p)
    {
        rb.velocity = new Vector2(speed, 0f);
        rb.gravityScale = 0;
        p.enabled = false;
        animator.SetBool("Dash", true);
        yield return new WaitForEndOfFrame();
        animator.SetBool("Dash", false);
        yield return new WaitForSeconds(animationTime);
        p.enabled = true;
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

}
