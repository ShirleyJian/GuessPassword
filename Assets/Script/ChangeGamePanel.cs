using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGamePanel : MonoBehaviour
{
    public GameObject GamePanel;

    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OpenPanel);
    }

    private void OpenPanel() 
    {
        GamePanel.SetActive(true);
        GameObject.Find("ShowAnimation").GetComponent<Show>().getPassword();
    }

    public void ClosePanel()
    {
        GameObject.Find("ShowAnimation").GetComponent<Image>().color = new Color(0, 0, 0, 255);
        GamePanel.SetActive(false);
        GameObject.Find("FromNumber").GetComponent<InputField>().text = "";
        GameObject.Find("toNumber").GetComponent<InputField>().text = "";
    }
}
