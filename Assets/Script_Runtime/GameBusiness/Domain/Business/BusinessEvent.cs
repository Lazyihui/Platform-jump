using System;


public class BusinessEvents {
    public Action Login_OnClickStartGameHandle;

    public void Login_OnClickStartGame() {
            Login_OnClickStartGameHandle();
    }

    public BusinessEvents() { }
}