using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchivementSpanwed : MonoBehaviour {

    public TextMeshProUGUI textname;
    public Image image;
    public TextMeshProUGUI textdesciption;

    public Sprite img;
    public string name;
    public string description;

    public void SetAchivement(Achivement achivement)
    {
        img = achivement.sprite;
        name = achivement.Name;
        description = achivement.Description;

        image.sprite = achivement.sprite;
        textname.text = achivement.Name;
        textdesciption.text = achivement.Description;
        StartCoroutine("Despawn");
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
