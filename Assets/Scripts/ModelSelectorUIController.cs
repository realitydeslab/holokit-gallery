using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelSelectorUIController : MonoBehaviour
{
    [SerializeField] private GalleryManager m_GalleryManager;

    [SerializeField] private GameObject m_ModelSlotPrefab;

    [SerializeField] private RectTransform m_Root;

    private void Start()
    {
        int idx = 0;
        foreach (var modelData in m_GalleryManager.Models)
        {
            var modelSlot = Instantiate(m_ModelSlotPrefab, m_Root);
            int i = idx;
            modelSlot.GetComponent<Button>().onClick.AddListener(() => { m_GalleryManager.OnModelSelected(i); });
            if (modelData.Image != null)
                modelSlot.GetComponent<Image>().sprite = modelData.Image;

            idx++;
        }
    }
}
