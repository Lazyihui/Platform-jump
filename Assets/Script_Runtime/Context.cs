using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context {

    public GameContext gameContext;

    public AssetsContext assetsContext;

    public ModuleInput moduleInput;

    public Context() {
        gameContext = new GameContext();
        assetsContext = new AssetsContext();
        moduleInput = new ModuleInput();
    }
    
    public void Inject(){
        gameContext.Inject(assetsContext, moduleInput);
    }

}
