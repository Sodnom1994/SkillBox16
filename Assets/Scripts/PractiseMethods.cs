using System.Linq;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PractiseMethods : MonoBehaviour
{
    [SerializeField] private GameObject Ladder;
    [SerializeField] private List<GameObject> steps;

    public void ChangeSizeObject()
    {
        Ladder.transform.localScale = new Vector3(3, 3, 3);
    }
    public void AddRigidBody()
    {
        if (steps == null || steps.Count == 0) return;

        for (int i = 0; i < steps.Count; i++)
        {
            if (steps[i] != null)
            {
                steps[i].AddComponent<Rigidbody>();
            }
            else
            {
                Debug.LogWarning("Ступенька с индексом " + i + " не существует!");
            }
        }
    }
    public void DeactivateObject()
    {
        Ladder.SetActive(false);
    }


}
