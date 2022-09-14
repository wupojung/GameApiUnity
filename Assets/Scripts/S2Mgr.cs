using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class S2Mgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string json = "[{\"id\":2,\"name\":\"lily\"},{\"id\":3,\"name\":\"candy\"}]";

        List<NPC> npcList = JsonConvert.DeserializeObject<List<NPC>>(json);

        foreach (var npc in npcList)
        {
            Debug.Log($"#{npc.id} -> {npc.name}");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}