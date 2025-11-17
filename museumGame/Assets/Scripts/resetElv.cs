using UnityEngine;

public class resetElv : MonoBehaviour
{

    public Animator elevatorAnimator;
    public Animator button1Animator;
    public Animator button2Animator;
    public Animator helpButtonAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetElevInt()
    {
        elevatorAnimator.SetInteger("moveElevator", 0);
        print("reset to 0");
    }

    public void resetButton1()
    {
        button1Animator.SetBool("pushButton", false);
        print("button 1 false now");
    }

    public void resetButton2()
    {
        button2Animator.SetBool("buttonPush", false);
        print("button 2 false now");
    }

    public void resetHelpButton()
    {
        helpButtonAnimator.SetBool("pushButton", false);
        print("help Button  false now");
    }

}
