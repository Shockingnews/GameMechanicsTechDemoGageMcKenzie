using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class CharacterControllerScript : MonoBehaviour
{

    public GameObject player;
    [SerializeField] Vector2 movementInput = new Vector2(0, 0);
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
        Vector3 movement = new Vector3(xMove, 0f, yMove);
        controller.Move(movement * Time.deltaTime * speed);
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
         movementInput = context.action.ReadValue<Vector2>();
        player.transform.forward = (movementInput);

        xMove = movementInput.x;
        yMove = movementInput.y;
    }

    public void OnJump()
    {

    }

}
