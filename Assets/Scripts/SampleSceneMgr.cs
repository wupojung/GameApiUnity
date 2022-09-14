using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class SampleSceneMgr : MonoBehaviour
{
    void Start()
    {
        // json 請於 json parser 網站中確認 是合法的
        // http://json.parser.online.fr/
        string json = "{\"id\":3,\"name\":\"admin\"}";
        
        //進行轉換
        RPG rpg = JsonConvert.DeserializeObject<RPG>(json); //轉換
        
        //確認資料正常
        if (rpg == null)
        {
            Debug.LogError("convert was NULL !!!");
        }
        else
        {
            Debug.Log($"id={rpg.id} , name ={rpg.name}");
        }
    }

    void Update()
    {
    }
}