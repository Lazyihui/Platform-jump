using System;
using UnityEngine;

public static class GameFactory {


    public static GameEntity Game_Create() {

        return new GameEntity();
    }

    public static RoleEntity Role_Create(GameContext ctx) {


        bool has = ctx.assetsContext.TryGetEntity("Role_Entity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Entity_Role ==null");
            return null;
        }
        RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
        role.Ctor();
        
        return role;
    }


}