

//用于整个游戏的数据类型
// 夸business
public class GameEntity {

    public GameFSMStatus status;

    public int roleOwnerID;

    public float restFixTime; //用于模拟 fixedUpdate使用的

    public GameEntity() {
        restFixTime = 0;

    }

}