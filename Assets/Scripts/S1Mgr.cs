using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class S1Mgr : MonoBehaviour
{
    void Start()
    {
        // json 請於 json parser 網站中確認 是合法的
        // http://json.parser.online.fr/
        string json = "{\"id\":3,\"name\":\"admin\"}";
        
        //進行轉換
        NPC npc = JsonConvert.DeserializeObject<NPC>(json); //轉換
        
        //確認資料正常
        if (npc == null)
        {
            Debug.LogError("convert was NULL !!!");
        }
        else
        {
            Debug.Log($"id={npc.id} , name ={npc.name}");
        }
    }

    void Update()
    {
    }
}