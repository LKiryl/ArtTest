using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsationButton : MonoBehaviour
{
    [SerializeField] private float _strength = 2f;
    [SerializeField] private float _speed = 1f;

    private Vector3 _originalScale;
    private bool _isPulsating = true;
    
    void Start()
    {
        _originalScale = transform.localScale;
        StartPulsation();
    }

    private void OnEnable()
    {
        StartButton.OnStartGame += StopPulsation;
    }

    private void OnDisable()
    {
        StartButton.OnStartGame -= StopPulsation;
        
    }



    // Update is called once per frame
    void Update()
    {
        if (_isPulsating)
        {
            float pulseScale = Mathf.PingPong(Time.time * _speed, 1f) * _strength;
            transform.localScale = _originalScale + Vector3.one * pulseScale;
        }
    }

    public void StartPulsation()
    {
        _isPulsating = true;
    }

    public void StopPulsation()
    {
        _isPulsating = false;
        transform.localScale = _originalScale;

    }
}
