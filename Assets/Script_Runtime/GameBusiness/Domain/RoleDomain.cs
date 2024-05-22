
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
}