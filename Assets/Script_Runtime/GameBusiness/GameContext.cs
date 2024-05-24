

public class GameContext {

    public RoleRespository roleRepository;

    public MstRepository mstRepository;

    public MapRepository mapRepository;

    // 
    public BusinessEvents events;

    public GameEntity gameEntity;

    public AssetsContext assetsContext;

    public ModuleInput moduleInput;





    public GameContext() {
        roleRepository = new RoleRespository();
        mstRepository = new MstRepository();
        mapRepository = new MapRepository();

        events = new BusinessEvents();


    }

    public void Inject(AssetsContext assetsContext,ModuleInput moduleInput) {
        this.assetsContext = assetsContext;
        this.moduleInput = moduleInput;


    }
}