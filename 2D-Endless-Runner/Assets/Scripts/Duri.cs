using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duri : MonoBehaviour
{
    [Header("Jump")]
    private float jumpAccel = 15;
    private float moveAccel = 5;
    private float maxSpeed = 5;

    private bool isJumping;
    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 velocityVector = rig.velocity;
        velocityVector.x = Mathf.Clamp(velocityVector.x + moveAccel * Time.deltaTime, 0.0f, maxSpeed);
        rig.velocity = velocityVector;
        if (isJumping)
        {
            velocityVector.y += jumpAccel;
            isJumping = false;

        }
    }

}
