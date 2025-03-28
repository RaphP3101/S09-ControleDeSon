using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionMusique : MonoBehaviour
{

    [SerializeField] AudioMixer _mixer;
    public void ChangerVolumemusique(float nouveauVolume)
    {
        Debug.Log("musique" + nouveauVolume);

        _mixer.SetFloat("VolumeMusique", nouveauVolume);
    }
}
