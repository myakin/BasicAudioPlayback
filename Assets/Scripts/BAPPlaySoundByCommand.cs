using UnityEngine;

public class BAPPlaySoundByCommand : MonoBehaviour
{
    public void PlaySound() {
        GetComponent<AudioSource>().Play();
    }
}
