using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [SerializeField]
    new private string name;

    public string Name
    {
        get { return name; }
    }

    [SerializeField]
    private int life = 100;

    public int Life
    {
        get { return life; }
        set { life = Mathf.Max(value, 0); } // Проверка > 0
    }

    [SerializeField]
    public float ImpactForce = 1f; // урон

    // Абстрактный метод
    public abstract void TakeDamage(int damageValue);

    // Виртуальный метод
    public virtual void ShowStat()
    {
        Debug.Log($"Name: {Name}, Life: {Life}");
    }
}