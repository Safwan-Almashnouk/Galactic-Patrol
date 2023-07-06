using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    [Header("shield")]
    public Image shieldImage;
    bool isCooldown = false;
    bool StartedCooldown;
    public KeyCode shield;
    public GameObject shieldobject;
    public BoxCollider Cd;
    public HealthAndDeath shipHealth;

  
    // Start is called before the first frame update
    void Start()
    {
        shieldImage.fillAmount = 0;
        Cd= GetComponent<BoxCollider>();
        shieldImage.fillAmount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        ShieldImage();
    }
    void ShieldImage()
    {
        if (Input.GetKey(shield) && !isCooldown)
        {
            isCooldown = true;
            shieldobject.SetActive(true);
            shipHealth.shieldActive = true;
        }
        if (isCooldown)
        {
            shieldImage.fillAmount -= 0.1f * Time.deltaTime;
        }
        if (shieldImage.fillAmount <= 0 && isCooldown && !StartedCooldown)
        {
            shieldImage.fillAmount = 0;
            shieldobject.SetActive(false);
            shipHealth.shieldActive = false;
            WaitForCooldown();
            loop();
        }


    }
    public IEnumerator WaitForCooldown()
    {
        StartedCooldown = true;
        yield return new WaitForSeconds(3);
        isCooldown = false;
        shieldImage.fillAmount = 2;

       
    }
    public IEnumerator loop()
    {
        while (isCooldown == false)
        {

            StartedCooldown = true;
            yield return new WaitForSeconds(3);
            isCooldown = false;
            shieldImage.fillAmount = 2;
            Debug.Log("o");
            StartCoroutine(WaitForCooldown());
        }
    }
    

}


