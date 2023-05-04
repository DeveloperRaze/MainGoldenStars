using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColour : MonoBehaviour
{

    //Set these Textures in the Inspector

    public Texture m_MainTexture;
    public Texture m_RedTexture;
    public Texture m_GreenTexture;

    public Renderer rend;

    public void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void SetMaterialBlue()
    {
        rend.material.SetTexture ("_MainTex", m_MainTexture);
    }

    public void SetMaterialRed()
    {
        rend.material.SetTexture("_MainTex", m_RedTexture);
    }

    public void SetMaterialGreen()
    {
        rend.material.SetTexture("_MainTex", m_GreenTexture);
    }

}
