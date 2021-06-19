using System.Collections.Generic;

public class IAPServiceImpl : IIAPService
{

    private IMasterDataRepository<IAPEntity> _masterDataRepository = new IAPLocalMasterDataRepository();


    private IMasterDataRepository<IAPEntity> MediationMasterDataRepository {
        get {
            return _masterDataRepository;
        }
    }


    public List<IAPDTO> GetAll()
    {
        List<IAPEntity> es = MediationMasterDataRepository.FindAll();
        return IAPDTOConvertor.From(es);
    }

    public List<IAPDTO> GetAllByType(IAPType type)
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

    public IAPDTO GetById(string id)
    {
        IAPEntity e = MediationMasterDataRepository.FindById(id);
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
