using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;


public class GameAsstets : MonoBehaviour
{

    private static GameAsstets _i;

    public static GameAsstets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAsstets>("GameAssets"));
            return _i;
        }
    }



    public Transform DamagePopUp;
}


