

public class GameContext {

    public RoleRespository roleRepository;

    public MstRepository mstRepository;

    // 
    public BusinessEvents events;

    public GameEntity gameEntity;

    public AssetsContext assetsContext;






    public GameContext() {
        roleRepository = new RoleRespository();
        mstRepository = new MstRepository();

        events = new BusinessEvents();


    }

    public void Inject(AssetsContext assetsContext) {
        this.assetsContext = assetsContext; 


    }
}