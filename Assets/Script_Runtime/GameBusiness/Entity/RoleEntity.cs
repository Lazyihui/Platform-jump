using System;
using UnityEngine;

public class RoleEntity : MonoBehaviour {
    [SerializeField] Transform Body;
    [SerializeField] Rigidbody2D rb;

    [SerializeField] SpriteRenderer sr;

    [SerializeField] Animator animator;

    public int id;
    public int allowJumpTimes;

    public void Ctor() { }

    public Vector2 Pos() {
        return Body.position;
    }

    public void SetPos(Vector2 pos) {
        Body.position = pos;
    }

    public Vector2 Velocity() {
        return rb.velocity;
    }


    public void Move(Vector2 moveAxis, float speed, float fixdt) {

        Vector2 oldVelocity = rb.velocity;
        oldVelocity.x = moveAxis.x * speed;
        rb.velocity = oldVelocity;

        Anim_Move(moveAxis.x);
        Face(moveAxis.x);
        // Vector2 moveDir = moveAxis.normalized;
        // rb.velocity = moveDir * 5;
        // if (moveDir.x > 0) {
        //     sr.flipX = false;
        // } else if (moveDir.x < 0) {
        //     sr.flipX = true;
        // }
        // animator.SetFloat("Speed", moveDir.magnitude);
    }

    void Face(float xDir) {
        if (xDir > 0) {
            Body.localScale = new Vector3(1, 1, 1);
        } else if (xDir < 0) {
            Body.localScale = new Vector3(-1, 1, 1);
        }
    }

    void Anim_Move(float xDir) {
        if (xDir != 0) {
            animator.Play("Run");
        } else {
            animator.Play("Idle");
        }
    }
    public void Falling(float fallingSpeed, float fallingSpeedMax, float fixdt) {

        Vector2 oldVelocity = rb.velocity;
        oldVelocity.y -= fallingSpeed * fixdt;
        if (oldVelocity.y < -fallingSpeedMax) {
            oldVelocity.y = -fallingSpeedMax;
        }
        rb.velocity = oldVelocity;

    }

    public void Jump(float jumpAxis, float jumpForce, float fixdt) {

        if (!AllowJump()) {
            return;
        }


        if (jumpAxis != 0) {
            Vector2 oldVelocity = rb.velocity;
            oldVelocity.y = jumpForce;
            rb.velocity = oldVelocity;
            // 减少跳跃次数
            allowJumpTimes -= 1;

        }

    }

    public void EnterGround() {
        allowJumpTimes = 2;
    }

    bool AllowJump() {
        return allowJumpTimes > 0;
    }


}