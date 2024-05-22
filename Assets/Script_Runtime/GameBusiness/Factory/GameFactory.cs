using System;
using UnityEngine;

public static class GameFactory {


    public static GameEntity Game_Create() {

        return new GameEntity();
    }

    public static RoleEntity Role_Create(GameContext ctx) {

        ctx.assetsContext.TryGetEntity("Role_Entity", out GameObject prefab);
        if(prefab == null) {
            Debug.LogError("RoleEntity prefab not found");
            return null;
        }
        RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
        role.Ctor();

        return role;
    }


}