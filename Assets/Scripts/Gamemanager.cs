using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
  [SerializeField]
  Transform startTrsPoint;

  public static Gamemanager instance;

  void Awake()
  {
    if(instance)
    {
        Destroy(gameObject);
    }
    else
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

  public Vector3 startPoint => startTrsPoint.position;
}
