using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth = 100.0f;
    public static float currentHealth;
    public float missingHealth;

    public float maxSheild;
    public float currentShield;

    public GameObject health;
    public GameObject shield;
    public GameObject shieldBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        missingHealth = maxHealth - currentHealth;
        maxSheild = maxHealth / 2;
        float healthWidth = currentHealth / maxHealth * 150f;
        float shieldWidth = currentShield / maxSheild * 72.25f;

        var healthRect = health.transform as RectTransform;
        healthRect.sizeDelta = new Vector2(healthWidth, healthRect.sizeDelta.y);

        var shieldRect = shield.transform as RectTransform;
        shieldRect.sizeDelta = new Vector2(shieldWidth, shieldRect.sizeDelta.y);

        var shieldBarRect = shieldBar.transform as RectTransform;

        if (currentShield > 0)
        {
            shieldBarRect.SetPositionAndRotation(new Vector3(12.5f, -35f, 120.9f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        else
        {
            shieldBarRect.SetPositionAndRotation(new Vector3(12.5f, 35f, 120.9f), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
}
