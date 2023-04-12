using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    #region Decleration
    public static event Action<string> InputPass;

    public bool IsshiftClick_bool;
    #endregion

    #region System Define Function
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetKey(KeyCode.RightShift));
        #region Shift
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            IsshiftClick_bool = true;
        }
        else if (Input.GetKey(KeyCode.LeftShift) == false && Input.GetKey(KeyCode.RightShift) == false)
        {
            IsshiftClick_bool = false;
        }
        #endregion

        Basic();
    }
    #endregion


    void Basic()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            Onclick_Zero();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            Onclick_One();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Onclick_Two();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            Onclick_Three();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            Onclick_Four();
        }
        if ((Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)) && !IsshiftClick_bool)
        {
            Onclick_Five();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            Onclick_Six();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            Onclick_Seven();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            Onclick_Eight();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            Onclick_Nine();
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus) || (Input.GetKeyDown(KeyCode.Equals) && IsshiftClick_bool))
        {
            Onclick_Pluse();
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
        {
            Onclick_Minuse();
        }
        if (Input.GetKeyDown(KeyCode.KeypadMultiply) || (Input.GetKeyDown(KeyCode.Alpha8) && IsshiftClick_bool))
        {
            Onclick_Multiplication();
        }
        if (Input.GetKeyDown(KeyCode.KeypadDivide) || Input.GetKeyDown(KeyCode.Slash))
        {
            Onclick_Division();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && IsshiftClick_bool)
        {
            Onclick_Percentage();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Onclick_BackSpace();
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Equals))
        {
            InputPass?.Invoke("Enter");
        }
        if (Input.GetKeyDown(KeyCode.Period) ||Input.GetKeyDown(KeyCode.KeypadPeriod))
        {
            Onclick_Dot();
        }
    }

    public void Onclick_Zero()
    {
        InputPass?.Invoke("0");
    }
    public void Onclick_One()
    {
        InputPass?.Invoke("1");
    }
    public void Onclick_Two()
    {
        InputPass?.Invoke("2");
    }
    public void Onclick_Three()
    {
        InputPass?.Invoke("3");
    }
    public void Onclick_Four()
    {
        InputPass?.Invoke("4");
    }
    public void Onclick_Five()
    {
        InputPass?.Invoke("5");
    }
    public void Onclick_Six()
    {
        InputPass?.Invoke("6");
    }
    public void Onclick_Seven()
    {
        InputPass?.Invoke("7");
    }
    public void Onclick_Eight()
    {
        InputPass?.Invoke("8");
    }
    public void Onclick_Nine()
    {
        InputPass?.Invoke("9");
    }
    public void Onclick_Pluse()
    {
        InputPass?.Invoke("+");
    }
    public void Onclick_Minuse()
    {
        InputPass?.Invoke("-");
    }
    public void Onclick_Multiplication()
    {
        InputPass?.Invoke("*");
    }
    public void Onclick_Division()
    {
        InputPass?.Invoke("/");
    }
    public void Onclick_Percentage()
    {
        InputPass?.Invoke("%");
    }
    public void Onclick_Enter()
    {
        InputPass?.Invoke("Enter");
    }
    public void Onclick_BackSpace()
    {
        InputPass?.Invoke("BackSpace");
    }
    public void Onclick_MC()
    {
        InputPass?.Invoke("MC");
    }
    public void Onclick_MR()
    {
        InputPass?.Invoke("MR");
    }
    public void Onclick_MS()
    {
        InputPass?.Invoke("MS");

    }
    public void Onclick_MPluse()
    {
        InputPass?.Invoke("M+");
    }
    public void Onclick_MMinuse()
    {
        InputPass?.Invoke("M-");
    }
    public void Onclick_MDown()
    {
        InputPass?.Invoke("MDown");
    }

    public void Onclick_CE()
    {
        InputPass?.Invoke("CE");
    }
    public void Onclick_C()
    {
        InputPass?.Invoke("C");
    }
    public void Onclick_OneDividedX()
    {
        InputPass?.Invoke("1/x");
    }
    public void Onclick_XSqure()
    {
        InputPass?.Invoke("x^2");
    }
    public void Onclick_SqrtX()
    {
        InputPass?.Invoke("sqrt(x)");
    }
    public void Onclick_Pluse_Minuse()
    {
        InputPass?.Invoke("+/-");
    }
    public void Onclick_Dot()
    {
        InputPass?.Invoke(".");
    }
}
