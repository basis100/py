using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScriptBase : MonoBehaviour {




        public List<Vector3> Points;

        public List<Vector3> RandomPoints ;

	// Use this for initialization
	void Start () 
    {

                Points = new List<Vector3>();
                RandomPoints = new List<Vector3>();

                Points.Add(new Vector3 { x = 50, y = 630,z = 0 });
                Points.Add(new Vector3 { x = 220, y = 630, z = 0 });
                Points.Add(new Vector3 { x = 390, y = 630, z = 0 });

                Points.Add(new Vector3 { x = 50, y = 440, z = 0 });
                Points.Add(new Vector3 { x = 220, y = 440, z = 0 });
                Points.Add(new Vector3 { x = 390, y = 440, z = 0 });

                Points.Add(new Vector3 { x = 50, y = 240, z = 0 });
                Points.Add(new Vector3 { x = 220, y = 240, z = 0 });
                Points.Add(new Vector3 { x = 390, y = 240, z = 0 });

                Points.Add(new Vector3 { x = 120, y = 75, z = 0 });
                Points.Add(new Vector3 { x = 310, y = 75, z = 0 });
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }		
	}

    public void ButtonQuit()
    {
        Application.Quit();     
    }

    public void ButtonShowHelp()
    {
        GameObject.Find("Canvas/PanelHelp").GetComponent<RectTransform>().position = new Vector3(0, 0, 0);
    }


    public void ButtonCloseHelp()
    {
        GameObject.Find("Canvas/PanelHelp").GetComponent<RectTransform>().localPosition = new Vector3(2000, 2000, 0);
    }



    public void ButtonWenHao()
    {

        RandomPoints.Clear();

        System.Random random = new System.Random();
 
        foreach (Vector3 item in Points)
        {
            RandomPoints.Insert(random.Next(RandomPoints.Count+1), item);
        }
      








        int j = 0;
        foreach (Vector3 one in RandomPoints)
        {
            GameObject.Find("Canvas/Panel/Win/B"+j.ToString()).GetComponent<RectTransform>().localPosition = one;
            j++;
        }

      

    }

}
