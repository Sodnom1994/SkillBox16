using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float moveSpeed = 1f; // Медленная скорость — как ты хочешь
    private Rigidbody rb;
    private Animator animator; // ← Нужен для установки параметра

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("На объекте должен быть Rigidbody!");
        }

        // Получаем Animator
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("На объекте должен быть Animator!");
        }
    }

    public void OnMoveButtonPressed()
    {
        // Двигаем объект вперёд
        rb.AddForce(transform.forward * moveSpeed, ForceMode.VelocityChange);
    }

    // Этот метод вызывается из Event после толкания двери
    public void StartMoving()
    {
        // Запускаем движение
        rb.AddForce(transform.forward * moveSpeed, ForceMode.VelocityChange);
    }

    // Обновляем анимацию каждый кадр
    void Update()
    {
        if (animator == null) return;

        // Вычисляем текущую скорость по оси Z
        float currentSpeed = Mathf.Abs(rb.linearVelocity.z);

        // Устанавливаем параметр в Animator
        animator.SetFloat("ItMoving", currentSpeed);
    }
}
