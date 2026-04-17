using UnityEngine;
using UnityEngine.Audio;

public class BAPMusicVolumeModifier : MonoBehaviour
{
    public Transform player;
    public AudioMixer mixer;
    public AudioMixerGroup musicGroup;

    private void Update() {
        float distance = (player.position - transform.position).magnitude;
        ModifyMusicVolume(Mathf.Clamp(-distance, -70, 0));
    }

    public void ModifyMusicVolume(float dbRate) {
        mixer.SetFloat("MusicVolume", dbRate);
    }

}
