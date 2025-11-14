using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class rayCast : MonoBehaviour
{

    //public TMP_Text detectionText;
    public Camera playerCam;
    public LayerMask layerMask;
    public galleryItem uiIsVisible;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //long way, lots of parameters to input
        //first argument is where it starts, second is where its going, hit detection is third, like where the collider is, max distance, last one not added here is if u want it to hit a certain layer
        
        //if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Mathf.Infinity))
        //{
        //    print("I hit something");
        //}

        //shorter way
        //Ray demoRay = new Ray(transform.position, transform.forward);
        //RaycastHit rayDetect;
        //Debug.DrawRay(transform.position, transform.forward, Color.red, Mathf.Infinity); //gives a visual of the ray

        ////if you don't put infinity it just assumes you go forever
        //if (Physics.Raycast(demoRay, out rayDetect))
        //{
        //    detectionText.text=rayDetect.collider.name;
        //}

        //for camera movement ray thing
        if (Input.GetMouseButtonDown(0))
        {
            mouseSelect();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (uiIsVisible.galleryPanel.activeSelf==true)
            {
                uiIsVisible.galleryPanel.SetActive(false);
            }
        }

       
    }


    public void mouseSelect()
    {
        Ray mouseRay=playerCam.ScreenPointToRay(Input.mousePosition); //built in function
        RaycastHit mouseDetect;
        
        if (Physics.Raycast(mouseRay, out mouseDetect, Mathf.Infinity, layerMask))
        {
            galleryItem galleryInfo = mouseDetect.collider.GetComponent<galleryItem>();
            uiIsVisible = galleryInfo;
            print("I have  been hit");
               
            galleryInfo.galleryPanel.SetActive(true);
            galleryInfo.panelText.text = galleryInfo.galleryText;
        }   
        
    }


    public IEnumerator waitToChangeBool()
    {
        yield return new WaitForSeconds(1f);
        print("UI = " + uiIsVisible);
    }

}
