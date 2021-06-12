using System.Collections.Generic;

public class IAPServiceImpl : IIAPService
{

    private IMasterDataRepository<IAPEntity> _masterDataRepository = new IAPLocalMasterDataRepository();


    private IMasterDataRepository<IAPEntity> MediationMasterDataRepository {
        get {
            return _masterDataRepository;
        }
    }


    public List<IAPDTO> GetAllIAPItems()
    {
        List<IAPEntity> es = MediationMasterDataRepository.FindAll();
        return IAPDTOConvertor.From(es);
    }

    public List<IAPDTO> GetAllIAPItemsByType(IAPType type)
    {
        List<IAPEntity> es = MediationMasterDataRepository.FindAll();
        List<IAPDTO> dtos = IAPDTOConvertor.From(es);
        
        List<IAPDTO> valuatedList = new List<IAPDTO>();

        foreach(IAPDTO dto in dtos) {
            if (dto.Type == type) {
                valuatedList.Add(dto);
            }
        }

        return valuatedList;
    }

    public IAPDTO GetById(IAPItemId id)
    {
        string rawId = IAPItemIdConvertor.From(id);
        IAPEntity e = MediationMasterDataRepository.FindById(rawId);
        return IAPDTOConvertor.From(e);
    }

    public void init()
    {
        _masterDataRepository.init();
    }

    public void lazyInit()
    {
        _masterDataRepository.lazyInit();
    }

    public void refresh()
    {
        _masterDataRepository.refresh();
    }
}
