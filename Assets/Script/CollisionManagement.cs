using UnityEngine;

public class CollisionManagement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверка на вход в триггер игроком
        Players player = other.GetComponent<Players>();
        Dragon dragon = GetComponent<Dragon>(); // Предполагаем, что скрипт прикреплен к объекту Dragon

        if (player != null && dragon != null)
        {
            // Дракон наносит урон игроку
            player.TakeDamage(dragon.Damage);

            // Вывод в консоль
            Debug.Log($"My name is {player.Name}");
            Debug.Log("I, the mighty dragon");
            Debug.Log($"Dragon caused {dragon.Damage} damage. Dragon's Life: {dragon.Life}");
            Debug.Log($"Player took {dragon.Damage} damage, remaining Life: {player.Life}, Experience: {player.Experience}");
        }
    }
}