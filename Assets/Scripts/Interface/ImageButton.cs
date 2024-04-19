using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageButton : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;

    private bool _isOn;

    private void Start()
    {
        _isOn = _targetObject.activeSelf;
    }

    public void ToggleObject()
    {
        _isOn= !_isOn;

        _targetObject.SetActive(_isOn);
    }
}
