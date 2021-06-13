using ChainPattern;

public class IAPServiceValidationPieceResult : IAsynPieceResult
{
    public const string PUBLIC_KEY = "IAPServiceValidationPieceResult";

    private bool _success;

    public IAPServiceValidationPieceResult(bool success)
    {
        _success = success;
    }

    public bool Success { get => _success; set => _success = value; }

    public string GetKey()
    {
        return PUBLIC_KEY;
    }
}

