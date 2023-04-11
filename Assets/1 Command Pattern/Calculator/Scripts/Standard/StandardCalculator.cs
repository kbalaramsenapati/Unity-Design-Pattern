using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices.WindowsRuntime;
using System;

namespace CommandPatterns.Calculator.Standard
{
    public class StandardCalculator : MonoBehaviour
    {
        #region Decleration

        public double Result_double;

        public double Number1_double;
        public double Number2_double;

        public string Operator_string;

        public bool IsSecondNumber_bool;


        public string UpNumberPlace_string;
        public TMP_Text UpNumberPlace_Text;
        public string DownNumberPlace_string;
        public TMP_Text DownNumberPlace_Text;

        #endregion
        #region System Define Function
        private void OnEnable()
        {
            InputHandler.InputPass += Onclick_SetValue;


            DownNumberPlace_string = "0";
            DownNumberPlace_Text.text = DownNumberPlace_string;
        }
        private void OnDisable()
        {
            InputHandler.InputPass -= Onclick_SetValue;
        }
        private void Start()
        {
            //float a = 10;
            //float b = 5;

            //Invoker invoker = new Invoker();
            //Calculator calculator = new Calculator(a, b);
            //AddCommand addCommand = new AddCommand(calculator);
            //SubCommand substractCommand = new SubCommand(calculator);

            //Debug.Log("Add : "+ invoker.ExecuteCommand(addCommand));
            //Debug.Log("Sub : "+ invoker.ExecuteCommand(substractCommand));
        }
        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.A))
            //{

            //    Debug.Log();
            //}
        }
        #endregion


        #region User Define Function
        public void Onclick_SetValue(string val)
        {
            //SetNumber_Text.text+=va;
            //Debug.Log(va);
            double a = Number1_double;
            double b = Number2_double;
            Invoker invoker = new Invoker();
            Calculator calculator = new Calculator(a, b);



            switch (val)
            {
                case "0":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "1":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "2":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "3":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "4":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "5":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "6":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "7":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "8":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "9":
                    DownNumberPlace_string = CheckNumber(int.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "-":
                    IsSecondNumber_bool = true;

                    SubCommand substractCommand = new SubCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(substractCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " - ";
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    Number2_double = 0;
                    break;
                case "+":
                    IsSecondNumber_bool = true;

                    AddCommand addCommand = new AddCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(addCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " + ";
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    Number2_double = 0;
                    break;
                case "*":
                    IsSecondNumber_bool = true;

                    MultiCommand multiCommand = new MultiCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(multiCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " + ";
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    Number2_double = 1;
                    break;
                case "/":
                    IsSecondNumber_bool = true;

                    DiviCommand diviCommand = new DiviCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(diviCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " + ";
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    Number2_double = 1;
                    break;
                case "%":
                    IsSecondNumber_bool = true;

                    PercentCommand percentCommand = new PercentCommand(calculator);
                    double tempnum1 = Number1_double;
                    Number1_double = invoker.ExecuteCommand(percentCommand);
                    Number2_double = 1;
                    UpNumberPlace_string = tempnum1.ToString() + " + "+ Number1_double.ToString();
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                    break;
                case ".":
                    break;
                case "Enter":
                    break;
                case "BackSpace":
                    break;
                case "MC":
                    break;
                case "MR":
                    break;
                case "M+":
                    break;
                case "M-":
                    break;
                case "MS":
                    break;
            }
        }

        #endregion

        string CheckNumber(int val)
        {
            double TempNum = 0;
            if (IsSecondNumber_bool)
            {
                if (Number2_double == 0)
                {
                    //TempNum = val.ToString();
                    TempNum = val;
                }
                else
                {
                    string tempnum1 = "";
                    if (Number2_double.ToString().Length < 15)
                    {
                        tempnum1 = Number2_double.ToString() + val.ToString();
                    }
                    else
                    {
                        tempnum1 = Number2_double.ToString();
                    }
                    TempNum = double.Parse(tempnum1);
                }
                Number2_double = TempNum;
            }
            else
            {
                if (Number1_double == 0)
                {
                    TempNum = val;
                }
                else
                {
                    string tempnum1 = "";
                    if (Number1_double.ToString().Length < 15)
                    {
                        tempnum1 = Number1_double.ToString() + val.ToString();
                    }
                    else
                    {
                        tempnum1 = Number1_double.ToString();
                    }
                    TempNum = double.Parse(tempnum1);
                }
                Number1_double = TempNum;
            }
            return TempNum.ToString();
        }
        //string CheckOperator(string val)
        //{
        //    string TempNum = "0";
        //    Calculator()
        //    //if(val == "%")
        //    //{

        //    //}
        //    //else
        //    //{

        //    //}
        //}
    }
}
