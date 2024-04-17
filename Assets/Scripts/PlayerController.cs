/*
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

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

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
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
                Started = true;
                curSpeedX = (transform.position.x - worldPosition.x) * speedModifier;
                curSpeedY = (transform.position.y - worldPosition.y) * 2 * speedModifier;
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

        characterController.Move(moveDirection * Time.deltaTime);

        if (transform.position.y < deathHeight)
        {
            Debug.Log("hello");
        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Terrain"))
        {
            //Destroy(collision.gameObject);
            Debug.Log("hi");
        }
        Debug.Log("hi2");
		//Destroy(gameObject);
	}
}
*/