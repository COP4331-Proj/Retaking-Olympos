using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolTipControler : MonoBehaviour
{
    Canvas canvas;
    public GameObject toolTip;
    Vector3 toolTipPos;
    private void Start()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    private void Update()
    {
        if (toolTip == null)
        {
            toolTip = GameObject.FindWithTag("ToolTip");
        }
        // If tooltip pos has been calculated, set tooltip to that position then move its position to be onscreen
        // Needed in update because resizing of tooltip occurs after the show tooltip event is called
        if (toolTipPos != null)
        {
            toolTip.transform.position = toolTipPos;
        }
        KeepTooltipOnScreen(toolTip);
    }

    public void ShowToolTip(Vector3 position, Item item)
    {
        if (toolTip == null)
        {
            toolTip = GameObject.FindWithTag("ToolTip");
        }
        toolTip.SetActive(true);

        toolTip.GetComponentInChildren<TextMeshProUGUI>().text = item.GetDescription();
        toolTip.transform.position = position;
        toolTipPos = position;
    }

    public void HideToolTip()
    {
        if (toolTip == null)
        {
            toolTip = GameObject.FindWithTag("ToolTip");
        }
        toolTip.SetActive(false);
    }

    // Keeps tooltip on screen relitive to canvas size
    void KeepTooltipOnScreen(GameObject tooltip)
    {
        RectTransform rectTransform = tooltip.GetComponent<RectTransform>();
        RectTransform canvasRectTransform = canvas.GetComponent<RectTransform>();

        // Difference in size between canvas and tooltip
        Vector2 sizeDelta = canvasRectTransform.sizeDelta - rectTransform.sizeDelta;
        // Tooltip pivot
        Vector2 toolTipPivot = rectTransform.pivot;
        // new calculated pos
        Vector2 newPosition = rectTransform.anchoredPosition;
        // X and y get clamped between -size delta * its pivot which is in the center of the screen, - size delta for the left / down
        // and + size delta * (1 - pivot) for the right / up
        newPosition.x = Mathf.Clamp(newPosition.x, -sizeDelta.x * toolTipPivot.x, sizeDelta.x * (1 - toolTipPivot.x));
        newPosition.y = Mathf.Clamp(newPosition.y, -sizeDelta.y * toolTipPivot.y, sizeDelta.y * (1 - toolTipPivot.y));

        // Lower position so item can be seen
        newPosition.y = newPosition.y - 60f;
        rectTransform.anchoredPosition = newPosition;

    }
}
