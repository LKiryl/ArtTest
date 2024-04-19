using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public static Action OnStartGame;

    [SerializeField] private GameObject[] _gameObjects;
    [SerializeField] private ParticleSystem _starsParticleSystem;

    private bool _isStarted = false;
    private void OnEnable()
    {
        OnStartGame += PlayStars;
        OnStartGame += ActivateObjects;
    }

    private void OnDisable()
    {
        OnStartGame -= PlayStars;
        OnStartGame -= ActivateObjects;
        
    }
    public void StartGame()
    {
        if (_isStarted) { return; }
        OnStartGame?.Invoke();
        _isStarted = true;
    }

    private void PlayStars()
    {
        if( _starsParticleSystem != null )
        {
            _starsParticleSystem.Play();
        }
        
    }

    private void ActivateObjects()
    {
        if( _gameObjects.Length > 0 )
        {
            foreach (GameObject obj in _gameObjects)
            {
                obj.SetActive(true);
            }
        }
        
    }
}
