using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    static public float maxHealth = 100;
    public float health = maxHealth;

    public void updateHealthBar()
    {
        slider.maxValue = maxHealth;
        slider.value = health;

        gradient.Evaluate(1f);
        fill.color = gradient.Evaluate(1f);
    }
    //public void SetHealth(int health)
    //{
    //    fill.color = gradient.Evaluate(slider.normalizedValue);
    //}

    public void TakeDamage(float damage)
    {
        health -= damage;
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
