using System;
using System.Collections;
using UnityEngine;


public static class Business_Game {

    public static void NewGame(GameContext ctx) {
        // 改变程序状态
        ctx.gameEntity.status = GameFSMStatus.Game;
        // 初始化游戏数据
        RoleEntity role = RoleDomain.Spawn(ctx);
        ctx.gameEntity.roleOwnerID = role.id; //记录主角
        // 生产数据

        MapDomain.Spawn(ctx, 1);

    }

    public static void LoadGame(GameContext ctx) {
        // 读取存档
    }


    public static void Tick(GameContext ctx, float dt) {

        // === Pre ===用于处理输入
        PreUpdate(ctx, dt);
        // ==== fix ====
        ref float restFixTime = ref ctx.gameEntity.restFixTime;
        restFixTime += dt;
        const float FIX_INTERVAl = 0.02f;

        if (restFixTime <= FIX_INTERVAl) {
            LogicFixUpdate(ctx, restFixTime);
            restFixTime = 0;
        } else {
            while (restFixTime >= FIX_INTERVAl) {
                LogicFixUpdate(ctx, FIX_INTERVAl);
                restFixTime -= FIX_INTERVAl;
            }

        }

        // ==== late ====
        // 用于处理渲染/UI显示
        LateUpdate(ctx, dt);


    }

    static void PreUpdate(GameContext ctx, float dt) { }

    static void LogicFixUpdate(GameContext ctx, float dt) { 
        //  逻辑
        var input = ctx.moduleInput;

        // for role
        ctx.roleRepository.Foreach((RoleEntity role) => {
            if (role.id == ctx.gameEntity.roleOwnerID) {
                RoleDomain.Move(ctx,role, dt);
            }
        });
    }

    static void LateUpdate(GameContext ctx, float dt) { }



}