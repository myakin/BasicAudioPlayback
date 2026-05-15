using UnityEngine;

public class BAPAnimalSoundPlayer : MonoBehaviour
{
    public string animalName = "Bear";
    private string activeState = "";

    public void Roar() {
        PlaySoundForState("Roar");
    }

    public void Attack() {
        PlaySoundForState("Attack");
    }
    public void AttackRoar() {
        PlaySoundForState("AttackRoar");
    }
    public void AttackHit() {
        PlaySoundForState("AttackHit");
    }

    public void Die() {
        PlaySoundForState("Die");
    }

    public void FootStep() {
        PlaySoundForState("Footstep");
    }

    public void Eat() {
        PlaySoundForState("Eat");
    }


    private void PlaySoundForState(string state) {
        if (activeState!=state) {
            activeState = state;
            string fileName = MakeSoundFileNameForState(state);
            AudioClip roarClip = Resources.Load(fileName) as AudioClip;
            GetComponent<AudioSource>().clip = roarClip;
        }

        float transposeValue = Random.Range(0.9f, 1.1f);
        GetComponent<AudioSource>().pitch = transposeValue;
        GetComponent<AudioSource>().Play();
    }

    private string MakeSoundFileNameForState(string state) {
        return animalName + "_" + state; // Bear_Roar
    }
}
