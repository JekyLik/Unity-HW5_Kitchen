using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField]
    private GameObject _lampPrefab; 

    private void Awake()
    {
        var lampRoot = GameObject.Find("LampRoot");
        Instantiate(_lampPrefab, lampRoot.transform.position, lampRoot.transform.rotation);
    }
}