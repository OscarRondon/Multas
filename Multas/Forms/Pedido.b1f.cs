
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace Multas.Forms
{

    [FormAttribute("142", "Forms/Pedido.b1f")]
    class Pedido : SystemFormBase
    {
        #region Constructor
        public Pedido()
        {
        }
        #endregion

        #region UI Components
        private SAPbouiCOM.StaticText lbl_Multas;
        private SAPbouiCOM.EditText txt_Multas;
        private SAPbouiCOM.Button btn_Multas;
        #endregion

        #region Initializers
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.lbl_Multas = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Multas").Specific));
            this.txt_Multas = ((SAPbouiCOM.EditText)(this.GetItem("txt_Multas").Specific));
            this.btn_Multas = ((SAPbouiCOM.Button)(this.GetItem("btn_Multas").Specific));
            this.btn_Multas.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.btn_Multas_ClickAfter);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.DataLoadAfter += new DataLoadAfterHandler(this.Form_DataLoadAfter);
            this.LoadAfter += new LoadAfterHandler(this.Form_LoadAfter);

        }


        private void OnCustomInitialize()
        {

        }
        #endregion

        #region Events
        private void Form_DataLoadAfter(ref SAPbouiCOM.BusinessObjectInfo pVal)
        {
            string nroOC = "";
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            try
            {
                if (this.UIAPIRawForm.Visible)
                {
                    nroOC = this.UIAPIRawForm.DataSources.DBDataSources.Item("OPOR").GetValue("DocNum", 0);
                    if (!string.IsNullOrEmpty(nroOC))
                    {
                        oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_C");
                        oConds = new SAPbouiCOM.Conditions();
                        oCond = oConds.Add();
                        oCond.Alias = "U_DocNumOC";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = nroOC;
                        oDBDS.Query(oConds);

                        this.txt_Multas.Value = oDBDS.Size > 0 ? oDBDS.Size.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Pedido.cs > Form_DataLoadAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }

        }

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            string nroOC = "";
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            try
            {
                if (this.txt_Multas != null)
                {
                    nroOC = this.UIAPIRawForm.DataSources.DBDataSources.Item("OPOR").GetValue("DocNum", 0);
                    if (!string.IsNullOrEmpty(nroOC))
                    {
                        oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_C");
                        oConds = new SAPbouiCOM.Conditions();
                        oCond = oConds.Add();
                        oCond.Alias = "U_DocNumOC";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = nroOC;
                        oDBDS.Query(oConds);

                        this.txt_Multas.Value = oDBDS.Size > 0 ? oDBDS.Size.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Pedido.cs > Form_LoadAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }

        }

        private void btn_Multas_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            MultaListado oMultaListado = null;
            SAPbouiCOM.Form oForm = null;
            SAPbouiCOM.DBDataSource oPurchaseOrderDBDS = null;
            try
            {
                oPurchaseOrderDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("OPOR");
                if (!string.IsNullOrEmpty(oPurchaseOrderDBDS.GetValue("DocNum", 0).Trim()))
                {
                    try
                    {
                        Application.SBO_Application.Forms.GetForm("Multas.Forms.MultaListado", 0).Select();
                        oForm = Application.SBO_Application.Forms.GetForm("Multas.Forms.MultaListado", 0);
                        oForm.Close();
                        oMultaListado = new MultaListado();
                        oMultaListado.Show();
                    }
                    catch
                    {
                        oMultaListado = new MultaListado();
                        oMultaListado.Show();
                    }

                    oForm = Application.SBO_Application.Forms.GetForm("Multas.Forms.MultaListado", 0);
                    oForm.Freeze(true);

                    oForm.Items.Item("txt_Prov").Enabled = true;
                    oForm.Items.Item("txt_agidp").Enabled = true;
                    ((SAPbouiCOM.EditText)oForm.Items.Item("txt_Prov").Specific).Value = oPurchaseOrderDBDS.GetValue("CardCode", 0).Trim();
                    ((SAPbouiCOM.EditText)oForm.Items.Item("txt_ocde").Specific).Value = oPurchaseOrderDBDS.GetValue("DocNum", 0).Trim();
                    oForm.Items.Item("btn_Buscar").Click();
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Pedido.cs > btn_Multas_ClickAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                if (oForm != null)
                    oForm.Freeze(false);
            }
        }
        #endregion

    }
}
