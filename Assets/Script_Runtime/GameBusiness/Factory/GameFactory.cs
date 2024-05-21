

public static class GameFactory {


    public static GameEntity Game_Create() { 

        return new GameEntity();
    }

    public static RoleEntity Role_Create() { 

        RoleEntity role = new RoleEntity();
        role.Ctor();
        return null;

    }


}