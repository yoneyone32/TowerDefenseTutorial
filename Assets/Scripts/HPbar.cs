using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    [SerializeField] private Image fillImage;

    public void setHP(float HPpercent)
    {
        fillImage.fillAmount = Mathf.Clamp01(HPpercent);
    }
}
