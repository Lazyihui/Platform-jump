

public class GameContext {

    public RoleRepository roleRepository;
    public int roleID;
    public GameContext() {
        roleRepository = new RoleRepository();
        roleID = 0;
    }

    public void Inject() { }
}