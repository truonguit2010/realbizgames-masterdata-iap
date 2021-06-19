using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IAPDTO
{
    [SerializeField]
    private string _rowId;

    [SerializeField]
    private string _id;

    [SerializeField]
    private IAPType _type;

    private string _localizedPriceString;

    public string Id { get => _id; set => _id = value; }
    public IAPType Type { get => _type; set => _type = value; }
    public string LocalizedPriceString { get => _localizedPriceString; set => _localizedPriceString = value; }
    public string RowId { get => _rowId; set => _rowId = value; }

    public override string ToString()
    {
        return string.Format("[IAPDTO Id: {0} Type: {1} LocalizedPriceString: {2}]", Id, Type, LocalizedPriceString);
    }
}
