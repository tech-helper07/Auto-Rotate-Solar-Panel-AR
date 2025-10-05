using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json.Linq;
using System;
using UnityEngine.UI;



public class getdata : MonoBehaviour
{
    Boolean isready = false;
    public Text field1T, field2T , field3T , field4T;
    public Transform upperT1,upperT2, upperT3,upperT4,upperT5,upperT6,upperT7,upperT8,upperT9,upperT10,upperT11,upperT12,upperT13,upperT14,upperT15,upperT16;
    private float preupper=0f;
    private void Start()
    {
        System.Threading.Thread.Sleep(1000);
    }
    void Update()
    {
        // A correct website page.
        StartCoroutine(GetRequest1("https://api.thingspeak.com/channels/2040586/feeds.json?api_key=C7JNN0KMQBINEQ9B&results=2"));
    
      
    }

    IEnumerator GetRequest1(string uri)
    {
        if (!isready)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
            {
                // Request and wait for the desired page.
                isready = true;
                yield return webRequest.SendWebRequest();

                string[] pages = uri.Split('/');
                int page = pages.Length - 1;

                switch (webRequest.result)
                {
                    case UnityWebRequest.Result.ConnectionError:
                    case UnityWebRequest.Result.DataProcessingError:
                        Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                        break;
                    case UnityWebRequest.Result.ProtocolError:
                        Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                        break;
                    case UnityWebRequest.Result.Success:

                        var b = JObject.Parse(webRequest.downloadHandler.text);
                        var b1 = b["feeds"];
                        var b2 = b1[1];
                        //Field 1 Thingspeak data
                        var b3 = b2["field1"];
                        float field1 = b3.ToObject<float>();
                        string a = field1.ToString();
                        field1T.text = a;


                        //Field 2 Thingspeak data
                        var b4 = b2["field2"];
                        float field2 = b4.ToObject<float>();
                        string q = field2.ToString();
                        field2T.text = q;

                        //Field 2 Thingspeak data
                        var b5 = b2["field3"];
                        float field3 = b5.ToObject<float>();
                        string p = field3.ToString();
                        field3T.text = p;

                        var b6 = b2["field4"];
                        float field4 = b6.ToObject<float>();
                        string c = field4.ToString();

                        var b7 = b2["field5"];
                        float field5 = b7.ToObject<float>();
                        string d = field5.ToString();
                        field4T.text = c+":"+d;

                        if(preupper!=field2)
                        {
                        upperT1.Rotate(0f, 0f, -preupper+field2);
                        upperT2.Rotate(0f, 0f, -preupper+field2);
                        upperT3.Rotate(0f, 0f, -preupper+field2);
                        upperT4.Rotate(0f, 0f, -preupper+field2);
                        upperT5.Rotate(0f, 0f, -preupper+field2);
                        upperT6.Rotate(0f, 0f, -preupper+field2);
                        upperT7.Rotate(0f, 0f, -preupper+field2);
                        upperT8.Rotate(0f, 0f, -preupper+field2);
                        upperT9.Rotate(0f, 0f, -preupper+field2);
                        upperT10.Rotate(0f, 0f, -preupper+field2);
                        upperT11.Rotate(0f, 0f, -preupper+field2);
                        upperT12.Rotate(0f, 0f, -preupper+field2);
                        upperT13.Rotate(0f, 0f, -preupper+field2);
                        upperT14.Rotate(0f, 0f, -preupper+field2);
                        upperT15.Rotate(0f, 0f, -preupper+field2);
                        upperT16.Rotate(0f, 0f, -preupper+field2);
                        preupper=field2;
                        }


                        Debug.Log("field1: " + field1 + " field2: " + field2 + " field3: " + field3);



                        break;
                }
                isready = false;
            }
        }
    }

 
}