using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public GameObject globalVars;
    public Globals globals;
    private PlayerController playerControllerScript;
    //
    float leftBound = -5;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        globalVars = GameObject.FindWithTag("GVars");
        globals = globalVars.GetComponent<Globals>();
        //
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = globals.baseSpeed*globals.speedMod;
        //Move Left
        if(!(playerControllerScript.gameOver)){
           transform.Translate(Vector3.left*Time.deltaTime * speed);//Moove current game object by changing position 
        }
        //Destroy obstacle if it is out of bounds
        if(((transform.position.x < leftBound)||(transform.position.y < leftBound))&& gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
