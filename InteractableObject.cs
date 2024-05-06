using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool isChest;
    public bool isEnemy;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isChest)
            {
                OpenChest();
            }
            else if (isEnemy)
            {
                AttackEnemy();
            }
        }
    }

    void OpenChest()
    {
        Debug.Log("Chest opened!");
    }

    void AttackEnemy()
    {
        Debug.Log("Attacking enemy!");
    }
}
