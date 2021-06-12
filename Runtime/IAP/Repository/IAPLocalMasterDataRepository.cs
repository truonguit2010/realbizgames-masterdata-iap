using System.Collections.Generic;

public class IAPLocalMasterDataRepository : GenericMasterDataRepository<IAPEntity>
{
    public const string JSON_FILE_PATH = "iap";
    public IAPLocalMasterDataRepository() : base(JSON_FILE_PATH) {
        
    }
}
