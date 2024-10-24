using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public Image shieldImage;
    public KeyCode shieldKey;
    public GameObject shieldObject;
    public BoxCollider shieldCollider;
    public HealthAndDeath shipHealth;

    public float shieldDuration = 5f; 
    public float cooldownTime = 3f;   
    private bool isCooldown = false;

    void Start()
    {
        shieldImage.fillAmount = 1;
        shieldCollider = GetComponent<BoxCollider>();
        shieldObject.SetActive(false);  
    }

    void Update()
    {
        HandleShield();
    }

    void HandleShield()
    {
        if (Input.GetKey(shieldKey) && !isCooldown)
        {
            ActivateShield();
        }

        if (isCooldown)
        {
            shieldImage.fillAmount -= 1 / cooldownTime * Time.deltaTime;

            if (shieldImage.fillAmount <= 0)
            {
                isCooldown = false;
                shieldImage.fillAmount = 1;
            }
        }
    }

    void ActivateShield()
    {
        shieldObject.SetActive(true);
        shipHealth.shieldActive = true;
        shieldImage.fillAmount = 1;
        StartCoroutine(DeactivateShieldAfterDuration());
    }

    IEnumerator DeactivateShieldAfterDuration()
    {
        yield return new WaitForSeconds(shieldDuration);
        shieldObject.SetActive(false);
        shipHealth.shieldActive = false;
        StartCoroutine(StartCooldown());
    }

    IEnumerator StartCooldown()
    {
        isCooldown = true;
        shieldImage.fillAmount = 1;
        yield return new WaitForSeconds(cooldownTime); 
    }
}
