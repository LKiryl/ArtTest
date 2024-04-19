using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SpriteAtlasSript : MonoBehaviour
{
    [SerializeField] private SpriteAtlas _atlas;
    [SerializeField] private string _spriteName;
    [SerializeField] private bool _isSpriteRenderer = true;

    void Start()
    {
        if(_isSpriteRenderer)
        {
            GetComponent<SpriteRenderer>().sprite = _atlas.GetSprite(_spriteName);
        }
        else
        {
            GetComponent<Image>().sprite = _atlas.GetSprite(_spriteName);
        }
        
    }

    
}
