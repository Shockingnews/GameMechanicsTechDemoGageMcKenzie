using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class CharacterControllerScript : MonoBehaviour
{
    public GameObject cam;

    float gravity = -9.15f;
    public GameObject player;
    [SerializeField] Vector2 movementInput = new Vector2(0, 0);
    [SerializeField] Vector2 rotationInput = new Vector2(0, 0);
    static float xRotation;
    static float yRotation;
    Vector3 velocity;
    [SerializeField] CharacterController controller;
    float xMove;
    float yMove;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity.y = gravity * Time.deltaTime;

        Vector3 movement = new Vector3(xMove, 0f, yMove);
        controller.Move(movement * Time.deltaTime * speed);
        controller.Move(velocity);

    }

    public void OnMove(InputAction.CallbackContext context)
    {
         movementInput = context.action.ReadValue<Vector2>();
        //player.transform.forward = (movementInput);

        xMove = movementInput.x;
        yMove = movementInput.y;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        

        if (controller.isGrounded)
        {
            Debug.Log(context.phase);
            if (context.started)
            {
                Debug.Log(context.phase);
            }
            Debug.Log(context.phase);
            if (context.performed)
            {
                //Debug.Log("context.performed");
                Vector3 moveUp = transform.up * 5f;
                controller.Move(moveUp);
            }
            Debug.Log(context.phase);
            if (context.canceled)
            {
                //Debug.Log("context.canceled");
            }
            Debug.Log(context.phase);
        }

    }
    public void OnLook(InputAction.CallbackContext context)
    {
        rotationInput = context.ReadValue<Vector2>();
        

        yRotation += rotationInput.y;
        xRotation += rotationInput.x;

         //gives you a limt on up and down movement
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        //rotates cam and player in the direction of mouse
        //cam.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
        transform.rotation = Quaternion.Euler( -yRotation, xRotation, 0f);

    }



}
