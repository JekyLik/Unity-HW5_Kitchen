using System.Collections.Generic;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _lampPrefabs; 

    private void Awake()
    {
        var lampPrefabIndex = Random.Range(0, _lampPrefabs.Count);
        var lampRoot = GameObject.Find("LampRoot");
        Instantiate(_lampPrefabs[lampPrefabIndex], lampRoot.transform.position, lampRoot.transform.rotation);
    }
}