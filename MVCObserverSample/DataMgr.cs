using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace MVCObserverSample
{
    public class DataMgr : MVCSubject
    {
        private int m_Value = 0;

        public int GetValue()
        {
            return m_Value;
        }

        public void Inc()
        {
            m_Value++;
            Update();
        }

        public void Dec()
        {
            m_Value--;
            Update();
        }

        public void Init()
        {
	        Notify( NotifyType.NT_INIT );
        }

        public void Update()
        {
	        Notify( NotifyType.NT_UPDATE );
        }
    }
}
