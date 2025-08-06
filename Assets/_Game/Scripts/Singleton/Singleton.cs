using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _ins;

    public static T Ins
    {
        get
        {
            if (_ins == null)
            {
                // Find singleton
                _ins = FindObjectOfType<T>();

                // Create new instance if one doesn't already exist.
                if (_ins == null)
                {
                    // Need to create a new GameObject to attach the singleton to.
                    _ins = new GameObject(nameof(T)).AddComponent<T>();
                }

            }
            return _ins;
        }
    }

}