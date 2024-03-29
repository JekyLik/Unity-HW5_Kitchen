using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    private Shelf[] _shelves;

    private void Awake()
    {
        _shelves = FindObjectsOfType<Shelf>();

        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += ItemSpawned;
        }
    }

    private void ItemSpawned()
    {
        foreach (var shelf in _shelves)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned -= ItemSpawned;
        }
    }
}