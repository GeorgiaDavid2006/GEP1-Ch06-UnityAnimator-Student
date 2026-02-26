using UnityEngine;
using UnityEngine.InputSystem;

public class CubeSpinner : MonoBehaviour
{
    public Animator animController;

    private int isRotatingHash = Animator.StringToHash("isRotating");

    void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed && animController.GetBool(isRotatingHash) == true)
        {
            animController.SetBool(isRotatingHash, false);
        }

        else if (context.performed && animController.GetBool(isRotatingHash) == false)
        {
            animController.SetBool(isRotatingHash, true);
        }
    }
}
