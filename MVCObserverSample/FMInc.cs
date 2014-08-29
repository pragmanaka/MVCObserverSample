using System;
using System.Windows.Forms;

namespace MVCObserverSample
{
    public partial class FMInc : Form
    {
        public FMInc()
        {
            InitializeComponent();
            m_Data = new DataMgr();
            m_View = new View(lblValue, m_Data);         
            m_Data.Attach(m_View);
            m_Data.Init();
        }

        DataMgr m_Data;
        View m_View;

        private void btnInc_Click(object sender, EventArgs e)
        {
            m_Data.Inc();
        }

        private void btnViewSub_Click(object sender, EventArgs e)
        {
            FMDec frmDec = new FMDec(m_Data);
            frmDec.Show();
        }
    }
}
