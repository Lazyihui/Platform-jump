using System;
using UnityEngine;


public static class Business_Login {

    public static void Enter(GameContext ctx) {


        ctx.gameEntity.status = GameFSMStatus.Login;
     }


    public static void Tick(GameContext ctx, float dt) {
    
    }

    public static void ProcessGUI(GameContext ctx) {
        // 开始游戏

        bool isClick = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 50), "开始游戏");
        if (isClick) {
            ctx.events.Login_OnClickStartGame();
        }
    }

}