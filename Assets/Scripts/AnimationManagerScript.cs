using UnityEngine;

public class AnimationManagerScript : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;
    [SerializeField] private Movement movement; // ← Привяжи скрипт движения!

    public void PlayPushAnimation()
    {
        if (dummyAnimator == null)
        {
            Debug.LogError("Animator не привязан в AnimationManagerScript!");
            return;
        }

        dummyAnimator.SetBool("ItsPushing", true);
    }

    // Этот метод будет вызван из Event в аниматоре
    public void StartMoving()
    {
        if (movement != null)
        {
            movement.OnMoveButtonPressed(); // ← Запускаем движение!
        }
        else
        {
            Debug.LogError("Скрипт движения не привязан!");
        }
    }
}
