using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class SoundCollectionSO : ScriptableObject
{
    [Header("Music")]
    public SoundSO[] MainMusic;


    [Header("SFX")]
    public SoundSO[] Stars;
    public SoundSO[] Button;


}
