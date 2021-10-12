using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sprite;

    float direction = 0.0f;
    float spriteDirection = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x <= 1.0f)
        {
            direction = 2.0f;
            spriteDirection = 0.87f;
        }
        else if (rb.position.x >= 7.0f)
        {
            direction = -2.0f;
            spriteDirection = -0.87f;
        }

        rb.velocity = new Vector2(direction, rb.velocity.y);
        transform.localScale = new Vector3(spriteDirection, 3.864427f, 1);
    }
}
