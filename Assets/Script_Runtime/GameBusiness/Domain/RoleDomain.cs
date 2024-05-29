
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




}