
using System;
using System.Collections;
using UnityEngine;

public static class RoleDomain {

    public static RoleEntity Spawn(GameContext ctx) {

        RoleEntity role = GameFactory.Role_Create(ctx);

        ctx.roleRepository.Add(role);

        return role;
    }


    public static void UnSpawn(GameContext ctx, int id) {

    }

    public static void MoveByOwnerInput(GameContext ctx, RoleEntity role, float fixdt) {

        var input = ctx.moduleInput;
        role.Move(input.moveAxis, 5, fixdt);

    }

    public static void JumpByOwnerInput(GameContext ctx, RoleEntity role, float fixdt) {

        var input = ctx.moduleInput;
        if (input.jumpAxis > 0) {
            Jump(ctx, role, input.jumpAxis, fixdt);
        }

    }


    public static void Jump(GameContext ctx, RoleEntity role, float jumpAxis, float fixdt) {

        role.Jump(jumpAxis, 10f, fixdt);

    }


    public static void Falling(GameContext ctx, RoleEntity role, float fixdt) {

        role.Falling(22.5f, 40f, fixdt);

    }

    public static void GroundCheck(GameContext ctx, RoleEntity role) {

        // Physics2D.BoxCastAll();//向下发射一个射线，检测是否在地面上
        // Physics2D.OverlapCircleAll();//检测是否在地面上


        if (role.Velocity().y > 0) {
            return;
        }

        Vector2 sixe = new Vector2(0.98f, 0.1f);
        float angle = 0;
        Vector2 dir = new Vector2(0, -1);
        RaycastHit2D[] hits = Physics2D.BoxCastAll(role.Pos(), sixe, angle, dir, 0.5f);

        if (hits.Length == 0) {
            return;
        }


        bool isCollideGound = false;

        for (int i = 0; i < hits.Length; i += 1) {
            RaycastHit2D hit = hits[i];
            if (hit.collider.gameObject.CompareTag("Ground")) {
                Debug.Log("ss");
                isCollideGound = true;
                break;
            }
        }
        if (isCollideGound) {
            role.EnterGround();
        }


        // var colliders = Physics2D.OverlapCircleAll(role.transform.position, 0.1f, 1 << 8);
        // if (colliders.Length > 0) {
        //     role.allowJumpTimes = 2;
        // } else {
        //     role.allowJumpTimes = 0;
        // }

    }


}