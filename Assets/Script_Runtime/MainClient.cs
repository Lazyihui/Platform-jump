using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClient : MonoBehaviour {

    bool isTearDown = false;

    Context ctx;
    void Awake() {


        // ====== instantiate ======
        ctx = new Context();
        ctx.gameContext.gameEntity = GameFactory.Game_Create();

        // =====  Bining =====
        BindingEvents();

        // =====  Init =====
        // ==== Enter ====
        Business_Login.Enter(ctx.gameContext);
    }


    void BindingEvents() {
        BusinessEvents businessEvents = ctx.gameContext.events;

        businessEvents.Login_OnClickStartGameHandle = () => {
            Business_Game.Enter(ctx.gameContext);
            Debug.Log("开始游戏");
        };
    }

    void OnGUI() {
        var game = ctx.gameContext.gameEntity;
        GameFSMStatus status = game.status;

        if (status == GameFSMStatus.Login) {
            Business_Login.ProcessGUI(ctx.gameContext);
        } else if (status == GameFSMStatus.Game){
            // Business_Game.ProcessGUI(ctx.gameContext);
        }

    }

    void Update() {

        float dt = Time.deltaTime;

        var game = ctx.gameContext.gameEntity;
        GameFSMStatus status = game.status;

        if (status == GameFSMStatus.Login) {
            Business_Login.Tick(ctx.gameContext, dt);
        } else if (status == GameFSMStatus.Game) {
            Business_Game.Tick(ctx.gameContext, dt);
        }

        

    }

    void OnDestory() {
        TearDown();
    }

    void OnApplicationQuit() {
        TearDown();
    }

    void TearDown() {
        if (isTearDown) {
            return;
        }
        isTearDown = true;
    }
}
