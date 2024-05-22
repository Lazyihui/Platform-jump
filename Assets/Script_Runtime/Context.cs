using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context {

    public GameContext gameContext;

    public AssetsContext assetsContext;

    public Context() {
        gameContext = new GameContext();
        assetsContext = new AssetsContext();

    }
    
    public void Inject(){
        gameContext.Inject(assetsContext);
    }

}
