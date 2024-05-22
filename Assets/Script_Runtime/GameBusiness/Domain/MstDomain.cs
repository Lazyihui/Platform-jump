using System;
using System.Collections;
using UnityEngine;


public static class MstDomain {
    public static MstEntity Spawn(GameContext ctx) {

       bool has =  ctx.assetsContext.TryGetEntity("Mst_Entity", out GameObject prefab);
        if (!has) {
            Debug.LogError("MstEntity prefab not found");
            return null;
        }
        MstEntity mst = GameObject.Instantiate(prefab).GetComponent<MstEntity>();
        mst.Ctor();
        return mst;
    }
}