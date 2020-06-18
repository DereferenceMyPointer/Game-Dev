using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public Animator animator;
    public float explosionTimer;
    public LayerMask[] layerMask;
    public float damage;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool connected = false;
        foreach (LayerMask layer in layerMask)
        {
            if (LayerMask.GetMask(LayerMask.LayerToName(collision.gameObject.layer)) == layer.value)
            {
                connected = true;
            }
        }
        if (connected)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            animator.SetBool("Explode", true);
            DestroyOffset(explosionTimer);
        }
        if (collision.gameObject.TryGetComponent<Health>(out Health health) && connected)
        {
            health.Damage(damage);
        }
    }

    public void DestroyOffset(float t)
    {
        StartCoroutine(Destruction(t));
    }

    public IEnumerator Destruction(float t)
    {   
        yield return new WaitForSeconds(t);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        animator.SetBool("Explode", true);
        Destroy(this.gameObject, explosionTimer);
    }
    
}
