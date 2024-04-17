using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PC : MonoBehaviour
{
    private StarsCheck StarsCheck;
    public float topSpeed;
    public float acceleration;
    public float decelleration;
    public float curSpeedX;
    public float curSpeedY;
    private Vector2 moveDirection = Vector2.zero;
    public bool gravity;
    public float gravityStrength;
    public float deathHeight;
    public bool KeyMode;
    public Vector3 worldPosition;
    public float speedModifier;
    public bool Started;
    Rigidbody2D r2d;
    public float clicks;
    public AudioSource airBurst;

    void Start(){

        Cursor.lockState = CursorLockMode.Confined;

        r2d = GetComponent<Rigidbody2D>();
        StarsCheck = GetComponent<StarsCheck>();
        clicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 up = transform.TransformDirection(Vector2.up);
            Vector2 right = transform.TransformDirection(Vector2.right);

        if(KeyMode){
            curSpeedX += acceleration * Input.GetAxis("Horizontal") * Time.deltaTime;
            curSpeedY += acceleration * Input.GetAxis("Vertical") * Time.deltaTime;

            if(curSpeedX > topSpeed) {curSpeedX = topSpeed;}
            if(curSpeedX < -topSpeed) {curSpeedX = -topSpeed;}
            if(curSpeedY > topSpeed) {curSpeedY = topSpeed;}
            if(curSpeedY < -topSpeed) {curSpeedY = -topSpeed;}

        }
        else{
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

            if(Input.GetButtonDown("Fire1")){
                clicks++;
                Started = true;
                curSpeedX = (transform.position.x - worldPosition.x) * speedModifier;
                curSpeedY = (transform.position.y - worldPosition.y) * speedModifier;
                airBurst.Play();
            }
        }
        
        if(curSpeedX > 0.01) {curSpeedX -= (curSpeedX * decelleration) * Time.deltaTime;}
        if(curSpeedX < -0.01) {curSpeedX += (-curSpeedX * decelleration) * Time.deltaTime;}
        if(curSpeedY > 0.01) {curSpeedY -= (curSpeedY * decelleration) * Time.deltaTime;}
        if(curSpeedY < -0.01) {curSpeedY += (-curSpeedY * decelleration) * Time.deltaTime;}

        if(gravity && Started){
            curSpeedY -= gravityStrength * Time.deltaTime;
        }
        
        moveDirection = (up * curSpeedY) + (right * curSpeedX);

        r2d.velocity = (moveDirection);

        if (transform.position.y < deathHeight){
            Debug.Log("hello");
        }

        if(Input.GetButtonDown("Cancel")){
            SceneManager.LoadScene(sceneName: "LevelsMenu");
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Finish")){
            StarsCheck.starsCheck(clicks);

            SceneManager.LoadScene(sceneName: "LevelsMenu");
        }
        if(collision.gameObject.CompareTag("Spikes")){
		    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("Spikes")){
		    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    public float GetClicks(){
        return clicks;
    }
}
