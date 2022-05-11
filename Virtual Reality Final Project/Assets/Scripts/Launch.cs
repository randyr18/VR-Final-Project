using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject arrow;
    private float minForce = 50f;
    private float maxForce = 300f;
    private bool isPulling = false;
    private bool mouseReleased = true;
    private float currentPullDuration = 0f;
    private float maxPullTime = 3f;
    private GameObject temp;
    void Start()
    {
        Debug.Log(arrow);
        temp = transform.Find("arrow").gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // to return to the main menu we press escape
        if (Input.GetKeyDown (KeyCode.Escape)){
            SceneManager.LoadScene("MainMenu");
            }

        if (Input.GetMouseButtonDown(0) && mouseReleased) // left click
        {
            currentPullDuration = 0f;
            isPulling = true;
            mouseReleased = false;
        }
        else if (isPulling && (Input.GetMouseButtonUp(0) || currentPullDuration >= maxPullTime)) {
            float launchForce = Mathf.Lerp(minForce, maxForce, currentPullDuration / maxPullTime);
            ThrowArrow(arrow, launchForce);

            //Reset
            currentPullDuration = 0f;
            isPulling = false;
        } 
        if (isPulling)
        {
            currentPullDuration += Time.deltaTime;
        }

        if (!mouseReleased)
        {
            mouseReleased = Input.GetMouseButtonUp(0);
        }
        
    }
    void ThrowArrow(GameObject arrow, float launchForce)
    {
        Debug.Log(transform.rotation.eulerAngles);
        GameObject thrownObject = Instantiate(arrow, transform.position, transform.rotation);
        Rigidbody rb = thrownObject.GetComponent<Rigidbody>();
        rb.AddForce(Camera.main.transform.forward * launchForce, ForceMode.Impulse);
        //GetComponent<AudioSource>().Play();
    }
}
