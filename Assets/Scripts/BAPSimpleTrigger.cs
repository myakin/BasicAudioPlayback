using UnityEngine;

public class BAPSimpleTrigger : MonoBehaviour
{
    public GameObject targetObject;
    public string onEnter;
    public string onExit;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && !string.IsNullOrEmpty(onEnter)) {
            targetObject.SendMessage(onEnter);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player" && !string.IsNullOrEmpty(onExit)) {
            targetObject.SendMessage(onExit);
        }
    }
}
