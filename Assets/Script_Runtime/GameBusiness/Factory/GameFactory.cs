using System;
using UnityEngine;

public static class GameFactory {


    public static GameEntity Game_Create() {

        return new GameEntity();
    }

    public static RoleEntity Role_Create(GameContext ctx) {

       

        return null;
    }


}