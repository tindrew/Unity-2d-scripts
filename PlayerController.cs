using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    // Necessary for animations and physics
    private Rigidbody2D rigidbody2d;
    private Animator playerAnimator;

    public float speed = 2.0f;
    public float horizontal; // = 1[or] -1[or]0
    public float vertical;

    // Start is called before the first frame update
    private void Start()
    {
        // get these to allow us to use them, define the gameobjects found on the player
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    // handles the input for physics
   private  void Update()
    {
        // check direction given by player
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    // handles running the physics
    private void FixedUpdate()
    {
        // move the character left and right
        rigidbody2d.velocity = new Vector2(horizontal*speed, rigidbody2d.velocity.y);
    }
}
