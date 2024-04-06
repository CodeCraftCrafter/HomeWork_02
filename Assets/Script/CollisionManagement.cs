using UnityEngine;

public class CollisionManagement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, содержит ли объект, с которым произошло столкновение, компонент Person
        Person person = other.GetComponent<Person>();

        if (person != null)
        {
            // Наносим урон, вызывая метод TakeDamage
            person.TakeDamage(30); // Предполагается, что значение урона равно 30

            Debug.Log("Damage applied to the player.");
        }
    }
}