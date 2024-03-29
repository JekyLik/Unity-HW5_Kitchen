using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    private Lamp[] _lampObjects;
    
    private void Awake()
    {
        _lampObjects = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            foreach (var LampObject in _lampObjects)
            {
                LampObject.Interact();
            }
        }
            
    }
}