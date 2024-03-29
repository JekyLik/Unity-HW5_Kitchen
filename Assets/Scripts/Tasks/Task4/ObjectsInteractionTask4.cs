using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [FormerlySerializedAs("_wafflePrefab")] [SerializeField] 
    private Waffle _waffle;

    private GameObject _waffleRoot;
    private Toaster _toaster;
    
    private void Awake()
    {
        _toaster = FindObjectOfType<Toaster>();
        _waffleRoot = GameObject.Find("WaffleRoot");
        _toaster.TimerIsUp += HandleTimerIsUp;
    }

    private void HandleTimerIsUp()
    {
        Instantiate(_waffle, _waffleRoot.transform.position, _waffleRoot.transform.rotation);
    }
    
    private void OnDestroy()
    {
        _toaster.TimerIsUp -= HandleTimerIsUp;
    }
}