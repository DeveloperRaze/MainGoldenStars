using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    Renderer m_Renderer;

    public Texture m_MainTexture, m_Normal, m_Metal;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Renderer from the GameObject
        m_Renderer = GetComponent<Renderer>();
    }

    public void ChangeToBlue()
    {
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
    }

    public void ChangeToGreen()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Normal);
    }

    public void ChangeToRed()
    {
        m_Renderer.material.SetTexture("_MainTex", m_Metal);
    }
}
