using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMang : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;

    public void ToggleDeathPanel()
    {
        deathPanel.SetActive(true);
    }

}
