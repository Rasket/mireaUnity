using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Movement : NetworkBehaviour
{
    public CharacterController characterController;

    public float speed = 12f;

    public float gravity = -9.8f;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void OnStartLocalPlayer()
    {

        base.OnStartLocalPlayer();
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;
    }

    public Transform GroundCheck;

    public float groundDistance = 0.4f;

    public LayerMask grundMask;

    public float JumpForce = 10f;

    bool isGrounded;
    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move((velocity * Time.deltaTime) / 2);

        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, grundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y += Mathf.Sqrt(JumpForce * -2f * gravity);
        }
    }
}
