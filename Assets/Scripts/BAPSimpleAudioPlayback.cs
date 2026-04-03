using UnityEngine;

public class BAPSimpleAudioPlayback : MonoBehaviour
{
    public AudioSource playbackTarget;
    
    public void PlaySound() 
    {
        playbackTarget.Play();
    }

    public void StopSound() {
        playbackTarget.Stop();
    }
}
