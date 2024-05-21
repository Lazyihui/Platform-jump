using System;
using UnityEngine;


public static class Business_Login {

    public static void Enter() { }

    public static void ProcessGUI() {
        // 开始游戏

        bool isClick = GUI.Button(new Rect(Screen.width/2-50, Screen.height/2-50, 100, 50), "开始游戏");
        if (isClick) {
            Debug.Log("开始游戏");
        }
    }

}