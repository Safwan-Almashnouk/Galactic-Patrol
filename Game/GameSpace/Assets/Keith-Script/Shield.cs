using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    [Header("shield")]
    public Image shieldImage;
    public float cooldown = 5;
    bool isCooldown = false;
    public KeyCode shield;
    public GameObject shieldobject;
    // Start is called before the first frame update
    void Start()
    {
        shieldImage.fillAmount = 0;
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
        }
        if (isCooldown)
        {
            shieldImage.fillAmount -= 1 / cooldown * Time.deltaTime;
        }
        if (shieldImage.fillAmount <= 0)
        {
            shieldImage.fillAmount = 0;
            isCooldown = false;
            shieldobject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name =="yes")
        {
            Destroy(gameObject);
            shieldobject.SetActive(true);
        }
    }
}
