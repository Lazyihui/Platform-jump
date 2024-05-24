using System;
using UnityEngine;

public class RoleEntity : MonoBehaviour {
    [SerializeField] Rigidbody2D rb;

    [SerializeField] SpriteRenderer sr;

    [SerializeField] Animator animator;

    public int id;


    public void Ctor() { }


    public void Move(Vector2 moveAxis, float speed, float fixdt) {

        Vector2 oldVelocity = rb.velocity;
        oldVelocity.x = moveAxis.x * speed;
        rb.velocity = oldVelocity;
        // Vector2 moveDir = moveAxis.normalized;
        // rb.velocity = moveDir * 5;
        // if (moveDir.x > 0) {
        //     sr.flipX = false;
        // } else if (moveDir.x < 0) {
        //     sr.flipX = true;
        // }
        // animator.SetFloat("Speed", moveDir.magnitude);
    }

    public void Falling(float fallingSpeed, float fallingSpeedMax, float fixdt) {

        Vector2 oldVelocity = rb.velocity;
        oldVelocity.y -= fallingSpeed * fixdt;
        if (oldVelocity.y < -fallingSpeedMax) {
            oldVelocity.y = -fallingSpeedMax;
        }
        rb.velocity = oldVelocity;

    }
}