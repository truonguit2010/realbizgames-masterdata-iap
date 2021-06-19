using System.Collections.Generic;
using ChainPattern;

public class IAPServiceValidationPiece : IAsynPieceExecutor
{
    const string TAG = "IAPServiceValidationPiece";

    private IIAPService iAPService;

    public bool IsDone => _result != null;

    public IAsynPieceResult Result => _result;

    private IAPServiceValidationPieceResult _result;

    public IAPServiceValidationPiece(IIAPService iAPService)
    {
        this.iAPService = iAPService;
    }

    public void Execute(IAsynChainResult data)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogFormat("{0} - Execute", TAG);
        #endif
        List<IAPDTO> dtos = iAPService.GetAll();
        #if UNITY_EDITOR
        string msg = ToStringForList(dtos);
        UnityEngine.Debug.LogFormat("{0} - {1}", TAG, msg);
        #endif
        
        _result = new IAPServiceValidationPieceResult(success: true);

        #if UNITY_EDITOR
        UnityEngine.Debug.LogFormat("{0} - End", TAG);
        #endif
    }

    public static string ToStringForList<T>(List<T> l) {
        string message = "Total: " + l.Count + "\n";
        foreach (T o in l) {
            message += o.ToString() + "\n";
        }
        return message;
    }
}
