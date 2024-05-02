using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform panel;
    private bool panelIsActive;

    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
        panelIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (panelIsActive == false)
            {
                panel.gameObject.SetActive(true);
                panelIsActive = true;
            }
            else
            {
                panel.gameObject.SetActive(false);
                panelIsActive = false;
            }
        }
    }
}
