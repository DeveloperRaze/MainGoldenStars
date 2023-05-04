using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Renderer m_Renderer;
    public ToggleCarColourChangeUI ToggleCarColourChangeUI;
    public Texture m_MainTexture, m_Normal, m_Metal;

    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (StaticNumberClass.carValue == 0)
        {
            SetBlue();
        }

        if (StaticNumberClass.carValue == 1)
        {
            SetGreen();
        }

        if (StaticNumberClass.carValue == 2)
        {
            SetRed();
        }
    }

    //Button press includes hide car colour UI
    public void ChangeToBlue()
    {
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
        ToggleCarColourChangeUI.HideCarColours();
        StaticNumberClass.carValue = 0;
    }

    //Button press includes hide car colour UI
    public void ChangeToGreen()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Normal);
        ToggleCarColourChangeUI.HideCarColours();
        StaticNumberClass.carValue = 1;
    }

    //Button press includes hide car colour UI
    public void ChangeToRed()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Metal);
        ToggleCarColourChangeUI.HideCarColours();
        StaticNumberClass.carValue = 2;
    }

    public void SetBlue()
    {
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
        StaticNumberClass.carValue = 0;
    }
    public void SetGreen()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Normal);
        StaticNumberClass.carValue = 1;
    }
    public void SetRed()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Metal);
        StaticNumberClass.carValue = 2;
    }
}
