using UnityEngine;
using System.Collections;

public class MYCollectible : MonoBehaviour
{
    private IEnumerator destroyCoroutine;
    public void Collect() {
        if (destroyCoroutine==null) {
            destroyCoroutine = DestroyCoroutine();
            StartCoroutine(destroyCoroutine);
        }
    }

    private IEnumerator DestroyCoroutine() {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
