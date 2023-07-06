using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    [Header("shield")]
    public Image shieldImage;
    public float cooldown = 25;
    bool isCooldown = false;
    public KeyCode shield;
    public GameObject shieldobject;
    bool shieldActive;
    public BoxCollider Cd;
    public HealthAndDeath shipHealth;

  
    // Start is called before the first frame update
    void Start()
    {
        shieldImage.fillAmount = 0;
        Cd= GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        ShieldImage();
    }
    void ShieldImage()
    {
        if (Input.GetKey(shield) && isCooldown == false)
        {
            isCooldown = true;
            shieldImage.fillAmount = 1;
            shieldobject.SetActive(true);
            shieldActive = true;
            shipHealth.shieldActive = true;
        }
        if (isCooldown)
        {
            shieldImage.fillAmount -= 10/ cooldown * Time.deltaTime;
        }
        if (shieldImage.fillAmount <= 0)
        {
            shieldImage.fillAmount = 0;
            isCooldown = false;
            shieldobject.SetActive(false);
            shieldActive = false;
            shipHealth.shieldActive = false;
        }
    }
    
}


