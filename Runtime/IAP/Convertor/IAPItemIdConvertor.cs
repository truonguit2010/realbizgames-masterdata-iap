using System.Collections.Generic;

public class IAPItemIdConvertor
{
    public static string From(IAPItemId id) {
        switch(id) {
            case IAPItemId.RemoveAllAds:
            return "remove_all_ads";
            case IAPItemId.RemoveBannerAds:
            return "remove_banner_ads";
            case IAPItemId.RemoveVideoAds:
            return "remove_video_ads";
            default:
            return string.Empty;
        }
    }
}
