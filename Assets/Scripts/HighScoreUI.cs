using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] GameObject highScoreUIElemtenPrefab;
    [SerializeField] Transform elementWrapper;

    private List<GameObject> uiElements = new List<GameObject>();
    public void UpdateUI(List<HighScoreElement> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            HighScoreElement el = list[i];

            if (el.points > 0)
            {
                if (i >= uiElements.Count)
                {
                    var inst = Instantiate(highScoreUIElemtenPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWrapper,false);

                    uiElements.Add(inst);
                }
                var texts = uiElements[i].GetComponentsInChildren<TextMeshProUGUI>();
                texts[0].text = i.ToString();
                texts[1].text = el.playerName;
                texts[2].text = el.points.ToString();

            }
        }
    }
}
