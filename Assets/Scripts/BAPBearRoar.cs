using UnityEngine;

public class BAPBearRoar : MonoBehaviour
{
    public string animalName = "Bear";
    private string activeState = "";

    public void Roar() {
        if (activeState!="Roar") {
            string fileName = MakeSoundFileNameForState("Roar");
            AudioClip roarClip = Resources.Load(fileName) as AudioClip;
            GetComponent<AudioSource>().clip = roarClip;
        }

        float transposeValue = Random.Range(0.9f, 1.1f);
        GetComponent<AudioSource>().pitch = transposeValue;
        GetComponent<AudioSource>().Play();

    }

    public void Attack() {

    }

    public void Die() {

    }

    private string MakeSoundFileNameForState(string state) {
        return animalName + "_" + state; // Bear_Roar
    }
}
