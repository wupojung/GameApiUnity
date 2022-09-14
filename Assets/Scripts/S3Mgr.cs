using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class S3Mgr : MonoBehaviour
{
    void Start()
    {
        string json = "{\"data\":[{\"id\":2,\"name\":\"lily\"},{\"id\":3,\"name\":\"candy\"}],\"name\":\"chinese card set\"}";

        HeroPool heros = JsonConvert.DeserializeObject<HeroPool>(json);

        if (heros != null)
        {
            Debug.Log($"We got a hero pool called ** {heros.name} **");
            foreach (var npc in heros.data)
            {
                Debug.Log($"#{npc.id} -> {npc.name}");
            }
        }
    }

    void Update()
    {
    }
}