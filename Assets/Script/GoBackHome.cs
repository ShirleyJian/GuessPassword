using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackHome : MonoBehaviour
{
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (GameObject.Find("Messange").GetComponent<Text>().text == "超過範圍了你這小壞壞~~")
        {
            GameObject.Find("ShowAnimation").GetComponent<Show>().ClosePanel();
        }
        else if (GameObject.Find("Messange").GetComponent<Text>().text == "遊戲結束囉!快懲罰那個小倒霉蛋吧")
        {
            GameObject.Find("NumberRange").GetComponent<Text>().text = "";
            GameObject.Find("ShowAnimation").GetComponent<Show>().ClosePanel();
            GameObject.Find("check").GetComponent<ChangeGamePanel>().ClosePanel();            
        }        
    }
}
