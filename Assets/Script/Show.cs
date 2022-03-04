using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System;

public class Show : MonoBehaviour
{
    public GameObject CheckPanel;
    string InputNumber;
    static string Password;
    int FromNumberText;
    int toNumberText;
    Boolean Isred = false;
    
    void Start()
    {
        InputNumber = GameObject.Find("InputNumber").GetComponent<Text>().text;        
    }

    public void getPassword() 
    {
        FromNumberText = int.Parse(GameObject.Find("FromNumberText").GetComponent<Text>().text);
        toNumberText = int.Parse(GameObject.Find("toNumberText").GetComponent<Text>().text);
        Password = Random.Range(FromNumberText, toNumberText).ToString();
        Debug.Log("Password=" + Password);
    }

    public void Check()
    {
        if (int.Parse(InputNumber) > toNumberText || int.Parse(InputNumber) < FromNumberText)
        {
            CheckPanel.SetActive(true);
            GameObject.Find("Messange").GetComponent<Text>().text = "超過範圍了你這小壞壞~~";
        }
        else {
            if (Password == InputNumber)
            {                
                InvokeRepeating("ChangeColor", 0.2f, 0.5f);
                Isred = true;
                CheckPanel.SetActive(true);
                GameObject.Find("Messange").GetComponent<Text>().text = "遊戲結束囉!快懲罰那個小倒霉蛋吧";
            }
            else
            {
                //InvokeRepeating("ChangeColor", 0.5f, 0.5f);

                if (int.Parse(InputNumber) > int.Parse(Password))
                    toNumberText = int.Parse(InputNumber);
                else
                    FromNumberText = int.Parse(InputNumber);

                GameObject.Find("NumberRange").GetComponent<Text>().text = "範圍:" + FromNumberText + "~" + toNumberText;
            }            
        }
        InputNumber = "";
    }

    public void Delete()
    {
        if (InputNumber != "")
            InputNumber = (int.Parse(InputNumber) / 10).ToString();
    }

    public void Push(String s)
    {
        InputNumber += s;
        Debug.Log("InputNumber=" + InputNumber);
    }

    public void ClosePanel()
    {
        CheckPanel.SetActive(false);
        CancelInvoke("ChangeColor");
    }

    public void ChangeColor()
    {
        if (this.gameObject.GetComponent<Image>().color != new Color(0, 0, 0, 255))
            this.gameObject.GetComponent<Image>().color = new Color(0, 0, 0, 255);
        else //if (Isred)
            this.gameObject.GetComponent<Image>().color = new Color(255, 0, 0, 255);
        //else
            //this.gameObject.GetComponent<Image>().color = new Color(0, 0, 255, 255);

        Debug.Log("InputNumber=" + InputNumber);
    }
}
