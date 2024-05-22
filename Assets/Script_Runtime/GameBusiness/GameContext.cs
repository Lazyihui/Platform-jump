

public class GameContext {

    public RoleRepository roleRepository;


    // 
    public BusinessEvents events;

    public GameEntity gameEntity;

    public AssetsContext assetsContext;


    

    public GameContext() {
        roleRepository = new RoleRepository();

        events = new BusinessEvents();
        assetsContext = new AssetsContext();


    }

    public void Inject() { }
}