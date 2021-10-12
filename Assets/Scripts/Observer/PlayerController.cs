using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sprite;

    public GameObject spawnPoint;
    public float jumpForce = 5.0f;

    public Transform groundCheck;

    private bool isGrounded;

    public static event Action enemyDestroyed;
    public Text valueText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (rb.position.y < -5.5)
        {
            rb.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
            rb.velocity = new Vector2(0, 0);
        }

        valueText.text = EnemyManager.Instance.value.ToString();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(2, rb.velocity.y);

            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);

            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            rb.velocity = new Vector2(rb.velocity.x, 8.0f);
            Destroy(col.gameObject);

            EnemyManager.Instance.value++;

            #region observer
            enemyDestroyed?.Invoke();
            #endregion
        }
    }
}
