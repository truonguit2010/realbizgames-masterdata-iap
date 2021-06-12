using System.Collections.Generic;

public interface IIAPService : IService
{
    List<IAPDTO> GetAllIAPItems();

    List<IAPDTO> GetAllIAPItemsByType(IAPType type);

    IAPDTO GetById(IAPItemId id);
}
