using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _sourceObjects;

    [SerializeField]
    private GameObject[] _additionalObjects;

    private void Start()
    {
        var randomAppender = new RandomAppender();
        randomAppender.AppendToArray(_sourceObjects, _additionalObjects);
    }
}
