using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class GameSessionHandler : MonoBehaviour
{
    public static GameSessionHandler Instance;
    public static int starCount;

    public void Start()
    {
        starCount = GameSession.starCount;
    }

    //NumberTree Star count

    //Levels 1-1
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;

    //Levels 1-2
    [SerializeField] GameObject star4;
    [SerializeField] GameObject star5;
    [SerializeField] GameObject star6;

    //Levels 1-3
    [SerializeField] GameObject star7;
    [SerializeField] GameObject star8;
    [SerializeField] GameObject star9;

    //Levels 1-4
    [SerializeField] GameObject star10;
    [SerializeField] GameObject star11;
    [SerializeField] GameObject star12;

    //Levels 1-5
    [SerializeField] GameObject star13;
    [SerializeField] GameObject star14;
    [SerializeField] GameObject star15;

    //Levels 1-6
    [SerializeField] GameObject star16;
    [SerializeField] GameObject star17;
    [SerializeField] GameObject star18;

    // Levels 1-1 Alphabet
    [SerializeField] GameObject star19;
    [SerializeField] GameObject star20;
    [SerializeField] GameObject star21;

    [SerializeField] GameObject star22;
    [SerializeField] GameObject star23;
    [SerializeField] GameObject star24;

    [SerializeField] GameObject star25;
    [SerializeField] GameObject star26;
    [SerializeField] GameObject star27;

    [SerializeField] GameObject star28;
    [SerializeField] GameObject star29;
    [SerializeField] GameObject star30;

    [SerializeField] GameObject star31;
    [SerializeField] GameObject star32;
    [SerializeField] GameObject star33;



    public void Update()
    {
        starCount = GameSession.starCount;
        Debug.Log(starCount + "StarCount");

        if (starCount == 1)
        {
            star1.SetActive(true);
        }
        if (starCount == 2)
        {
            star2.SetActive(true);
        }
        if (starCount == 3)
        {
            star3.SetActive(true);
        }
        if (starCount == 4)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
        }
        if (starCount == 5)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
        }
        if (starCount == 6)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
        }
        if (starCount == 7)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
        }
        if (starCount == 8)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
        }
        if (starCount == 9)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
        }
        if (starCount == 10)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
        }
        if (starCount == 11)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
        }
        if (starCount == 12)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star12.SetActive(true);
        }
        if (starCount == 13)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
        }
        if (starCount == 14)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
        }
        if (starCount == 15)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
        }
        if (starCount == 16)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
        }
        if (starCount == 17)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
        }
        if (starCount == 18)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
        }

        if (starCount == 19)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
        }
        if (starCount == 20)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
        }
        if (starCount == 21)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
        }

        if (starCount == 22)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
        }
        if (starCount == 23)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
        }
        if (starCount == 24)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
        }

        if (starCount == 25)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
        }
        if (starCount == 26)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
        }
        if (starCount == 27)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
        }

        if (starCount == 28)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
        }
        if (starCount == 29)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
            star29.SetActive(true);

        }
        if (starCount == 30)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
            star29.SetActive(true);
            star30.SetActive(true);
        }

        if (starCount == 31)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
            star29.SetActive(true);
            star30.SetActive(true);
            star31.SetActive(true);
        }
        if (starCount == 32)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
            star29.SetActive(true);
            star30.SetActive(true);
            star31.SetActive(true);
            star32.SetActive(true);
        }
        if (starCount == 33)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
            star10.SetActive(true);
            star11.SetActive(true);
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
            star19.SetActive(true);
            star20.SetActive(true);
            star21.SetActive(true);
            star22.SetActive(true);
            star23.SetActive(true);
            star24.SetActive(true);
            star25.SetActive(true);
            star26.SetActive(true);
            star27.SetActive(true);
            star28.SetActive(true);
            star29.SetActive(true);
            star30.SetActive(true);
            star31.SetActive(true);
            star32.SetActive(true);
            star33.SetActive(true);
        }
    }
}
