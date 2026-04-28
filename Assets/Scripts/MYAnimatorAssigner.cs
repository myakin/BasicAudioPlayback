using UnityEngine;

public class MYAnimatorAssigner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.tag=="Player") {
            other.GetComponent<MYInputManager>().animatorToControl = GetComponent<Animator>();
            MYWarningsManager.instance.Warn("You are now controlling animator of "+transform.name);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag=="Player") {
            other.GetComponent<MYInputManager>().animatorToControl = null;
            MYWarningsManager.instance.Warn("You left "+transform.name+", animator control session ended.");
        }
    }
}
