using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public static class ModuleAssets {

    public static void Load(AssetsContext ctx) {

        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "Entity";
            var ptr = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var go in list) {
                ctx.entities.Add(go.name, go);
            }
            ctx.entityPtr = ptr;

        }
        {
            var op = Addressables.LoadAssetsAsync<GameObject>("MapGrid",null);
            var list = op.WaitForCompletion();
            foreach(var go in list){
                MapGridElement mapGrid = go.GetComponent<MapGridElement>();
                ctx.mapGrids.Add(mapGrid.stageID, mapGrid);
            }
            ctx.mapPtr = op;
        }

    }

    public static void Unload(AssetsContext ctx) {
        if (ctx.entityPtr.IsValid()) {
            Addressables.Release(ctx.entityPtr);
        }
        if (ctx.mapPtr.IsValid()) {
            Addressables.Release(ctx.entityPtr);
        }
    }




}