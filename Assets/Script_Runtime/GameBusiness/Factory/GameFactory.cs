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
        role.allowJumpTimes = 2;

        return role;
    }


    public static MapEntity Map_Create(GameContext ctx, int stageID) {
        bool has = ctx.assetsContext.TryGetEntity("Map_Entity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Entity_Map ==null");
            return null;
        }
        MapEntity map = GameObject.Instantiate(prefab).GetComponent<MapEntity>();
        if (map == null) {
            Debug.LogError("MapEntity ==null");
            return null;
        }
        map.Ctor();
        map.stageID = stageID;

        bool has1 = ctx.assetsContext.TryGetMapGrid(stageID, out MapGridElement mapGridElement);
        if (!has1) {
            Debug.LogError("MapGridElement ==null");
            return null;
        }

        MapGridElement grid = GameObject.Instantiate(mapGridElement).GetComponent<MapGridElement>();
        map.Inject(grid);

        return map;


    }


}