using System;
using UnityEngine;


public static class MapDomain {

    public static MapEntity Spawn(GameContext ctx, int stageID) {
        MapEntity map = GameFactory.Map_Create(ctx, stageID);
        ctx.mapRepository.Add(map);
        return map;
    }
}