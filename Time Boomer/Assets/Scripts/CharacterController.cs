using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    float speed;
    Rigidbody2D rb2d;
    Vector2 horizontalVelocity;
    Vector2 verticalVelocity;
    Vector2 finalVelocity;

    bool grounded;
    [SerializeField]
    float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Mathf.Abs(horizontal) > 0.1f) {
            horizontalVelocity = new Vector2(horizontal, rb2d.velocity.y);
        }

        if (vertical > Mathf.Abs(0.1f))
        {
            verticalVelocity = new Vector2(0, vertical);
        }
        finalVelocity = horizontalVelocity; // + verticalVelocity;
        rb2d.velocity = finalVelocity;
        Debug.Log(finalVelocity);
    }
}
