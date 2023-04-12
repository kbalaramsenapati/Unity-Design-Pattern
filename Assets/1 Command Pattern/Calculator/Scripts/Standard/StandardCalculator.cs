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

        public enum Operator_enum {none,add,sub,multi,divi };
        public Operator_enum operator_Enum;

        public Button MC_button;
        public Button MR_button;
        public Button MPluse_button;
        public Button MMinuse_button;
        public Button MS_button;
        public Button MDown_button;

        #endregion
        #region System Define Function
        private void OnEnable()
        {
            InputHandler.InputPass += Onclick_SetValue;


            DownNumberPlace_string = "0";
            DownNumberPlace_Text.text = DownNumberPlace_string;

            MC_button.interactable = false;
            MR_button.interactable = false;
            MDown_button.interactable = false;
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
            //Debug.Log(val);
            double a = Number1_double;
            double b = Number2_double;
            Invoker invoker = new Invoker();
            Calculator calculator = new Calculator(a, b);



            switch (val)
            {
                case "0":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "1":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "2":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "3":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "4":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "5":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "6":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "7":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "8":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "9":
                    DownNumberPlace_string = CheckNumber(double.Parse(val));
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "-":
                    operator_Enum = Operator_enum.sub;
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
                    operator_Enum = Operator_enum.add;
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
                    operator_Enum = Operator_enum.multi;
                    IsSecondNumber_bool = true;

                    MultiCommand multiCommand = new MultiCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(multiCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " * ";
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    Number2_double = 1;
                    break;
                case "/":
                    operator_Enum = Operator_enum.divi;
                    IsSecondNumber_bool = true;

                    DiviCommand diviCommand = new DiviCommand(calculator);
                    Number1_double = invoker.ExecuteCommand(diviCommand);
                    UpNumberPlace_string = Number1_double.ToString() + " / ";
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
                    UpNumberPlace_string = tempnum1.ToString() + " + " + Number1_double.ToString();
                    UpNumberPlace_Text.text = UpNumberPlace_string;

                    DownNumberPlace_string = Number1_double.ToString();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case ".":
                    //Debug.Log(".1");
                    DownNumberPlace_string = CheckPeriod();
                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    break;
                case "Enter":
                    switch(operator_Enum)
                    {
                        case Operator_enum.add:
                            AddCommand addCommand1 = new AddCommand(calculator);
                            double add = Number1_double;
                            Number1_double = invoker.ExecuteCommand(addCommand1);
                            UpNumberPlace_string = add.ToString() + " + " + Number2_double.ToString() + " = ";
                            UpNumberPlace_Text.text = UpNumberPlace_string;

                            DownNumberPlace_string = Number1_double.ToString();
                            DownNumberPlace_Text.text = DownNumberPlace_string;
                            break;
                        case Operator_enum.sub:
                            SubCommand substractCommand1 = new SubCommand(calculator);
                            double sub = Number1_double;
                            Number1_double = invoker.ExecuteCommand(substractCommand1);
                            UpNumberPlace_string = sub.ToString() + " - " + Number2_double.ToString() + " = ";
                            UpNumberPlace_Text.text = UpNumberPlace_string;

                            DownNumberPlace_string = Number1_double.ToString();
                            DownNumberPlace_Text.text = DownNumberPlace_string;
                            break;
                        case Operator_enum.multi:
                            MultiCommand multiCommand1 = new MultiCommand(calculator);
                            double mul = Number1_double;
                            Number1_double = invoker.ExecuteCommand(multiCommand1);
                            UpNumberPlace_string = mul.ToString() + " * " + Number2_double.ToString() + " = ";
                            UpNumberPlace_Text.text = UpNumberPlace_string;

                            DownNumberPlace_string = Number1_double.ToString();
                            DownNumberPlace_Text.text = DownNumberPlace_string;

                            break;
                        case Operator_enum.divi:
                            DiviCommand diviCommand1 = new DiviCommand(calculator);
                            double div = Number1_double;
                            Number1_double = invoker.ExecuteCommand(diviCommand1);
                            UpNumberPlace_string = div.ToString() + " / " + Number2_double.ToString() + " = ";
                            UpNumberPlace_Text.text = UpNumberPlace_string;

                            DownNumberPlace_string = Number1_double.ToString();
                            DownNumberPlace_Text.text = DownNumberPlace_string;

                            break;
                    }
                    break;
                case "BackSpace":
                    if(DownNumberPlace_string=="0")
                    {
                        return;
                    }

                    DownNumberPlace_string = DownNumberPlace_string.Remove(DownNumberPlace_string.Length - 1);

                    if(DownNumberPlace_string.Length == 0)
                    {
                        DownNumberPlace_string = "0";
                    }

                    DownNumberPlace_Text.text = DownNumberPlace_string;
                    if (IsSecondNumber_bool)
                    {
                        Number2_double = double.Parse(DownNumberPlace_string);
                    }
                    else
                    {
                        Number1_double = double.Parse(DownNumberPlace_string);
                    }
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
                case "C":
                    Number1_double = 0;
                    Number2_double = 0;
                    UpNumberPlace_string = "";
                    UpNumberPlace_Text.text = UpNumberPlace_string;
                    DownNumberPlace_string = "0";
                    DownNumberPlace_Text.text = DownNumberPlace_string;

                    operator_Enum = Operator_enum.none;

                    break;

            }
        }

        #endregion

        string CheckNumber(double val)
        {
            double TempNum = 0;
            if (IsSecondNumber_bool)
            {
                if (DownNumberPlace_string == "0" || Number2_double==0)
                {
                    //TempNum = val.ToString();
                    TempNum = val;
                }
                else
                {
                    string tempnum1 = "";
                    if (DownNumberPlace_string.Length < 15)
                    {
                        tempnum1 = DownNumberPlace_string + val;
                    }
                    else
                    {
                        tempnum1 = DownNumberPlace_string;
                    }
                    TempNum = double.Parse(tempnum1);
                }
                Number2_double = TempNum;
            }
            else
            {
                if (DownNumberPlace_string == "0")
                {
                    TempNum = val;
                }
                else
                {
                    string tempnum1 = "";
                    if (DownNumberPlace_string.Length < 15)
                    {
                        tempnum1 = DownNumberPlace_string + val.ToString();
                    }
                    else
                    {
                        tempnum1 = DownNumberPlace_string;
                    }
                    TempNum = double.Parse(tempnum1);
                }
                Number1_double = TempNum;
            }
            return TempNum.ToString();
        }
        string CheckPeriod()
        {
            string tempNum = "";
            if (IsSecondNumber_bool)
            {
                string tempstring = Number2_double.ToString();
                if (!tempstring.Contains("."))
                {
                    tempstring = Number2_double.ToString() + ".";
                    Number2_double = double.Parse(tempstring);

                    tempNum = Number2_double.ToString();

                }
            }
            else
            {
                string tempstring = Number1_double.ToString();
                //Debug.Log(".2");
                if (!tempstring.Contains("."))
                {
                    Debug.Log(Number1_double);
                    tempstring = Number1_double.ToString() + ".";
                    Number1_double = double.Parse(tempstring);

                    tempNum = tempstring.ToString();

                }
            }
            return tempNum;
        }
    }
}
