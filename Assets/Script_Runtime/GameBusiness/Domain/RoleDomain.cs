
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

    public static void Move(GameContext ctx,RoleEntity role,float fixdt) {

        var input = ctx.moduleInput;
        role.Move(input.moveAxis, 5, fixdt);

    }
}