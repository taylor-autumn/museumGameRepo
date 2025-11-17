using UnityEngine;

public class buttonRayCast : MonoBehaviour
{
    public Camera playerCam;
    public Animator button1Animator;
    public Animator button2Animator;
    public Animator helpButtonAnimator;
    public Animator elevatorAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            hitButton();
        }

    }
    public void hitButton()
    {
        Ray mouseRay = playerCam.ScreenPointToRay(Input.mousePosition); //built in function
        RaycastHit mouseDetect;

        if (Physics.Raycast(mouseRay, out mouseDetect, Mathf.Infinity))
        {
            if (mouseDetect.collider.gameObject.CompareTag("button"))
            {
                print("button hit");
                button1Animator.SetBool("pushButton", true);
                elevatorAnimator.SetInteger("moveElevator", 1);
                print("set 1 move down");
            }

            if (mouseDetect.collider.gameObject.CompareTag("button2"))
            {
                print("button hit");
                button2Animator.SetBool("buttonPush", true);
                elevatorAnimator.SetInteger("moveElevator", 2);
                print("set 2 move up");
            }

            if (mouseDetect.collider.gameObject.CompareTag("helpButton"))
            {
                print("Help button hit");
                helpButtonAnimator.SetBool("pushButton", true);
                elevatorAnimator.SetInteger("moveElevator", 1);
                print("set 1 move down");
            }


        }

    }

}
