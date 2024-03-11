using UnityEngine;
using UnityEngine.InputSystem;

public class SendInput : MonoBehaviour
{
    public PlayerInput input;

    public Move moveRed;
    public Move moveGreen;
    public PauseToggle pause;

    InputAction moveRedAction;
    InputAction moveGreenAction;
    InputAction pauseAction;

    void Reset()
    {
        input = GetComponent<PlayerInput>();
    }

    void OnEnable()
    {
        moveRedAction = input.actions.FindAction("MoveRed");
        moveGreenAction = input.actions.FindAction("MoveGreen");
        pauseAction = input.actions.FindAction("Pause");
        input.onActionTriggered += OnAction;
    }

    void OnDisable()
    {
        input.onActionTriggered -= OnAction;
    }

    void OnAction(InputAction.CallbackContext context)
    {
        if (context.action == moveRedAction)
        {
            moveRed.OnMove(context.ReadValue<Vector2>());
        }
        else if (context.action == moveGreenAction)
        {
            moveGreen.OnMove(context.ReadValue<Vector2>());
        }
        else if (context.action == pauseAction)
        {
            pause.OnPause();
        }
    }
}
