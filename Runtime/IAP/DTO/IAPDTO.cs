using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class IAPDTO
{
    [SerializeField]
    private string _id;

    [SerializeField]
    private IAPType _type;

    public string Id { get => _id; set => _id = value; }
    public IAPType Type { get => _type; set => _type = value; }

    public override string ToString()
    {
        return string.Format("[IAPDTO Id: {0} Type: {1}]", Id, Type);
    }
}
