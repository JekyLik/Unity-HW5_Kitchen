using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    [SerializeField] 
    private Refrigerator _refrigerator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            _refrigerator.Interact();
    }
}
