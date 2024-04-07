using UnityEngine;

public class Dragon : Person
{
    public int Damage = 50; // Урон

    public override void TakeDamage(int damageValue, bool gainExp = true)
    {
        Life -= damageValue;
        Debug.Log("I, the mighty dragon. " +
                  $"Took {damageValue} damage, remaining Life: {Life}");
    }

    public void Attack(Players player)
    {
        // При атаке игрока, мы вызываем TakeDamage с gainExp = false, чтобы опыт не начислялся
        player.TakeDamage(Damage, false);
        Debug.Log($"Player took {Damage} damage from the dragon, remaining Life: {player.Life}");
    }

    public override void ShowStat()
    {
        Debug.Log($"Dragon's Life: {Life}");
    }
}