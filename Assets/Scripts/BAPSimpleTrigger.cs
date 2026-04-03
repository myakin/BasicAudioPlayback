using UnityEngine;

public class BAPSimpleTrigger : MonoBehaviour
{
    public GameObject targetObject;
    public string onEnter;
    public string onExit;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            targetObject.SendMessage(onEnter);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            targetObject.SendMessage(onExit);
        }
    }
}
