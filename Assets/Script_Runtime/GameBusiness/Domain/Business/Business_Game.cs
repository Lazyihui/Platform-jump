using System;
using System.Collections;
using UnityEngine;


public static class Business_Game{

    public static void Enter(GameContext ctx) { 

        ctx.gameEntity.status = GameFSMStatus.Game;
    }


    public static void Tick (GameContext ctx,float dt) {

        Debug.Log("Business_Game Tick");
        // === Pre ===用于处理输入
        PreUpdate(ctx,dt);
        // ==== fix ====
        ref float restFixTime = ref ctx.gameEntity.restFixTime;
        restFixTime += dt;
        const float FIX_INTERVAl = 0.02f;

        if(restFixTime<=FIX_INTERVAl){
            LogicFixUpdate(ctx,restFixTime);
            restFixTime = 0;
        }else{
            while(restFixTime>=FIX_INTERVAl){
                LogicFixUpdate(ctx,FIX_INTERVAl);
                restFixTime -= FIX_INTERVAl;
            }

        }
        
        // ==== late ====
        // 用于处理渲染/UI显示
        LateUpdate(ctx,dt);


     }

    static void PreUpdate(GameContext ctx,float dt) { }

    static void LogicFixUpdate(GameContext ctx,float dt) { }

    static void LateUpdate(GameContext ctx,float dt) { }  



}