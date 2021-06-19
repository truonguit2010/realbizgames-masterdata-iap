using System.Collections.Generic;
using UnityEngine;

public class IAPDTOConvertor
{
    public static IAPDTO From(IAPEntity e)
    {
        IAPDTO dto = new IAPDTO();

        dto.RowId = e.id;
        
        dto.Id = Application.platform == RuntimePlatform.Android ? e.android : e.ios;

        if ("Non-Consumable" == e.type) {
            dto.Type = IAPType.Non_Consumable;
        } else if ("Consumable" == e.type) {
            dto.Type = IAPType.Consumable;
        } else {
            dto.Type = IAPType.Subsciption;
        }
        dto.LocalizedPriceString = e.price;
        
        return dto;
    }

    public static List<IAPDTO> From(List<IAPEntity> es)
    {
        List<IAPDTO> dtos = new List<IAPDTO>();

        foreach(IAPEntity e in es) {
            IAPDTO dto = From(e);
            dtos.Add(dto);
        }
        
        return dtos;
    }
}
