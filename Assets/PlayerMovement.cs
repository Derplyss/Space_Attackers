using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float maxplayerspeed = 5;
    float playerspeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerspeed = 0;
        
        var leftkeyinput = Input.GetKey(KeyCode.LeftArrow);
        var rightkeyinput = Input.GetKey(KeyCode.RightArrow);

        if (leftkeyinput)
            playerspeed = playerspeed - maxplayerspeed;
        else if (rightkeyinput)
            playerspeed = playerspeed + maxplayerspeed; 
       

        
        var pos = transform.position;
        pos.x = transform.position.x + playerspeed *Time.deltaTime; 
        transform.position = pos;
    }
}
 