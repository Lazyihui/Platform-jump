using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class AssetsContext {


    public Dictionary<string, GameObject> entities;


    public AsyncOperationHandle entityPtr;


    public Dictionary<int , MapGridElement> mapGrids;

    public AsyncOperationHandle mapPtr;

    public AssetsContext() {
        entities = new Dictionary<string, GameObject>();
        mapGrids = new Dictionary<int, MapGridElement>();
    }
    public bool TryGetEntity(string name, out GameObject entity) {
        return entities.TryGetValue(name, out entity);
    }

    public bool TryGetMapGrid(int id, out MapGridElement entity) {
        return mapGrids.TryGetValue(id, out entity);
    }

}