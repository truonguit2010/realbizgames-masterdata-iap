using System.Collections.Generic;

public interface IIAPService : IService
{
    List<IAPDTO> GetAll();

    List<IAPDTO> GetAllByType(IAPType type);

    IAPDTO GetById(string id);
}
