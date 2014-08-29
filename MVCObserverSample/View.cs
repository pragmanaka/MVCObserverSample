using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace MVCObserverSample
{
    class View : MVCObserver
    {
        public View( Control ctrl, DataMgr data )
        {
            m_Control = ctrl;
            m_Data = data;
        }

        Control m_Control;
        DataMgr m_Data;

        public override void Update()
        {
            m_Control.Text = m_Data.GetValue().ToString();
        }

        public override void Init()
        {
            Update();
        }
    }
}
