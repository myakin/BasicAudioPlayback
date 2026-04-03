using UnityEngine;

public class BAPSimpleAudioTrigger : MonoBehaviour
{
    public GameObject targetObject;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            targetObject.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            targetObject.GetComponent<AudioSource>().Stop();
        }
    }
}
