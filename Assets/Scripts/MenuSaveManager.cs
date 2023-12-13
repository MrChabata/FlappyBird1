using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSaveManager : MonoBehaviour
{
    public Text recordTxt;
    public Text fishRecordTxt;
    public Slider slider;
    void Start()
    {
        LoadVolume();
        LoadRecord();
        LoadFishRecord();
        //PlayerPrefs.SetFloat("Glod", 13500000.90909876754f);
        //PlayerPrefs.SetInt("HP", 5);
        //PlayerPrefs.SetString("ObjectName", "Glod");

        //float glod = PlayerPrefs.GetFloat("Glod");
        //nt hp = PlayerPrefs.GetInt("HP");
        //string objectName = PlayerPrefs.GetString("ObjectName");

        //print(glod);
        //print(hp);
        //print(objectName);

        //int xp = PlayerPrefs.GetInt("XP", -1);
        //print(xp);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DeleteRecord()
    {   
        PlayerPrefs.DeleteKey("Record");
        recordTxt.text = "0";

    }

    public void DeleteFishRecord()
    {
        PlayerPrefs.DeleteKey("FishRecord");
        fishRecordTxt.text = "0";
    }

    public void LoadRecord()
    {
        int record = PlayerPrefs.GetInt("Record", 0);
        recordTxt.text = record.ToString();
    }

    public void LoadFishRecord()
    {
        int fishRecord = PlayerPrefs.GetInt("FishRecord", 0);
        fishRecordTxt.text = fishRecord.ToString();
    }

    public void LoadVolume()
    {
        float volume = PlayerPrefs.GetFloat("Volume", 0);
        slider.value = volume;
    }
}
