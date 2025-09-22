using UnityEngine;
using UnityEngine.Playables;

public class TimeLinesDirector : MonoBehaviour
{
    [SerializeField] private PlayableDirector leftDoorMech;
    [SerializeField] private PlayableDirector rightDoorMech;
    [SerializeField] private PlayableDirector TorchGroup;
    [SerializeField] private AnimationManagerScript animationManager;
    public void OpenDoors()
    {
        if (leftDoorMech == null || rightDoorMech == null || animationManager == null)
        {
            Debug.LogError("Один из компонентов не привязан в TimeLinesDirector!");
            return;
        }

        leftDoorMech.Play();
        rightDoorMech.Play();
        TorchGroup.Play();
        animationManager.PlayPushAnimation(); // ← Запускаем толкание
    }
}

