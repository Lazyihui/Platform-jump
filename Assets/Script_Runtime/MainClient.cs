using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClient : MonoBehaviour {

    bool isTearDown = false;

    Context ctx;
    void Awake() {


        // ====== instantiate ======
        ctx = new Context();

    }


    void OnGUI() {
        Business_Login.ProcessGUI();
    }

    void Update() {


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
