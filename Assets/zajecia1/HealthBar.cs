using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   
public Slider slider;
[SerializeField] private Health playerHealth;


public void SetMaxHealth(int health)
{
	slider.maxValue = health;
	slider.value = health;
}

public void SetHealth(int health)
{
	slider.value = health;
}


}
