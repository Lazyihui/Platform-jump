
using System;
using System.Collections;
using UnityEngine;

public static class RoleDomain {

    public static RoleEntity Spawn(GameContext ctx) {

        bool has = ctx.assetsContext.TryGetEntity("Role_Entity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Entity_Role ==null");
            return null;
        }
        RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
        role.Ctor();

        return role;
    }


    public static void UnSpawn(GameContext ctx, int id) {

    }
}