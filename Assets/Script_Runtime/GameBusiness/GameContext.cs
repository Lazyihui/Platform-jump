

public class GameContext {

    public RoleRepository roleRepository;

    public int roleID;

    // 
    public BusinessEvents events;

    public GameEntity gameEntity;

    

    public GameContext() {
        roleRepository = new RoleRepository();
        roleID = 0;

        events = new BusinessEvents();

    }

    public void Inject() { }
}