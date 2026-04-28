using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class MYWarningsManager : MonoBehaviour
{
    public static MYWarningsManager instance;

    private void Awake() {
        instance = this;
    }

    public TextMeshProUGUI warningsTMP;

    private Queue<string> warnings = new Queue<string>();
    private IEnumerator warningsCoroutine;

    public void Warn(string message) {
        warnings.Enqueue(message);
        if (warningsCoroutine==null) {
            warningsCoroutine = WarningsCoroutine();
            StartCoroutine(warningsCoroutine);
        }
    }

    private IEnumerator WarningsCoroutine() {
        while (warnings.Count>0) {
            warningsTMP.SetText(warnings.Dequeue());
            yield return new WaitForSeconds(3);
            warningsTMP.SetText("");
        }
        warningsCoroutine = null;
    }
}
