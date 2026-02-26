using UnityEngine;
using UnityEngine.InputSystem;

public class MegamanAnim : MonoBehaviour
{
    public Animator animController;

    public Vector2 movementInput;

    private int moveInputHash = Animator.StringToHash("MoveInputX");

    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        animController.SetFloat(moveInputHash, movementInput.x);
    }
}
