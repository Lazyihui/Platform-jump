using System;
using UnityEngine;
using UnityEngine.Tilemaps;


public class MapEntity : MonoBehaviour {

    public int id;
    public int stageID;

    MapGridElement grid;


    public void Ctor() { }

    public void Inject(MapGridElement grid) {
        this.grid = grid;
    }
}