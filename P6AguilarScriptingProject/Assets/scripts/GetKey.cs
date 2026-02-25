using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            Debug.Log("Get Key Down Is: " + down);
        }
        else if (held)
        {
            Debug.Log("Key held is: " + held);
        }
        else if (up)
        {
            Debug.Log("Get key is up: " + up);
        }
        else
        {
            Debug.Log("Get Key Down is: " + down);
            Debug.Log("Key held is: " + held);
            Debug.Log("Get key up is: " + up);
        }
        
    }
}
