using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : LevelCondition
{
    private float m_time;

    private GameManager m_mngr;

    private Coroutine TimeTextRoutine;

    public override void Setup(float value, Text txt, GameManager mngr)
    {
        base.Setup(value, txt, mngr);

        m_mngr = mngr;

        m_time = value;
        UpdateText();        
    }

    private void Start()
    {
        TimeTextRoutine = StartCoroutine(UpdateTimeRoutine());
    }

    private void OnDestroy()
    {
        if (TimeTextRoutine != null) StopCoroutine(TimeTextRoutine);
    }

    private void Update()
    {
        if (m_conditionCompleted) return;

        if (m_mngr.State != GameManager.eStateGame.GAME_STARTED) return;

        // Old code
        //m_time -= Time.deltaTime;
        //UpdateText();

        //if (m_time <= -1f)
        //{
        //    OnConditionComplete();
        //}
    }

    protected override void UpdateText()
    {
        if (m_time < 0f) return;

        m_txt.text = string.Format("TIME:\n{0:00}", m_time);
    }

    protected IEnumerator UpdateTimeRoutine()
    {        
        while (true)
        {
            yield return new WaitForSeconds(1f);

            if (m_conditionCompleted) continue;
            if (m_mngr.State != GameManager.eStateGame.GAME_STARTED) continue;
            
            m_time -= 1;
            UpdateText();

            if (m_time < -0)
            {
                OnConditionComplete();                
            }
        }        
    }
}
