using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandle : MonoBehaviour
{
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (this.gameObject.transform.GetChild(0).GetComponent<Text>().text == "確認送出")
            GameObject.Find("ShowAnimation").GetComponent<Show>().Check();
        else if (this.gameObject.transform.GetChild(0).GetComponent<Text>().text == "刪除")
            GameObject.Find("ShowAnimation").GetComponent<Show>().Delete();
        else
            GameObject.Find("ShowAnimation").GetComponent<Show>().Push(this.gameObject.transform.GetChild(0).GetComponent<Text>().text);
    }
}
