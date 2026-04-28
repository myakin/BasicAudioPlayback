using UnityEngine;

public class MYInputManager : MonoBehaviour
{
    public Animator animatorToControl;

    private float timer = 5;
    private void Update()
    {
        bool verP = Input.GetKey(KeyCode.T);
        bool verN = Input.GetKey(KeyCode.G);
        float multiplier = Input.GetKey(KeyCode.LeftShift) ? 2 : 1;
        bool eat = Input.GetKeyDown(KeyCode.Alpha1);
        bool attack = Input.GetKeyDown(KeyCode.Alpha2);
        bool die = Input.GetKeyDown(KeyCode.Alpha3);
        
        if (animatorToControl) {
            if (verP) {
                animatorToControl.SetFloat("Forward", multiplier);
            } else {
                animatorToControl.SetFloat("Forward", 0);
            }
            
            if (eat) {
                animatorToControl.SetBool("Eat", !animatorToControl.GetBool("Eat"));
                MYWarningsManager.instance.Warn("Animator state Eat is "+animatorToControl.GetBool("Eat")+". Pressing this key again will trigger idle state.");
            }
            if (attack) {
                animatorToControl.SetBool("Attack", !animatorToControl.GetBool("Attack"));
                MYWarningsManager.instance.Warn("Animator state Attack is "+animatorToControl.GetBool("Attack")+". Pressing this key again will trigger idle state.");
            }
            if (die) {
                animatorToControl.SetBool("DieHard", !animatorToControl.GetBool("DieHard"));
                if (animatorToControl.GetBool("DieHard")) {
                    animatorToControl.SetTrigger("Die");
                    MYWarningsManager.instance.Warn("You killed animal. Press the key again to revive.");
                } else { 
                    animatorToControl.SetTrigger("Revive");
                    MYWarningsManager.instance.Warn("You revived animal.");
                }
                
            }
        } else {
            if (timer > 4 && (verP || eat || attack || die)) {
                timer = 0;
                MYWarningsManager.instance.Warn("You do not posses an animal animator. Get closer to one.");
            }
        }

        timer += Time.deltaTime;
    }
}
