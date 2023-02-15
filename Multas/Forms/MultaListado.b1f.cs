using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace Multas.Forms
{
    [FormAttribute("Multas.Forms.MultaListado", "Forms/MultaListado.b1f")]
    class MultaListado : UserFormBase
    {
        #region Constructor
        public MultaListado()
        {
        }
        #endregion

        #region UI Components
        private SAPbouiCOM.Button Cancel;
        private SAPbouiCOM.StaticText lbl_Prov;
        private SAPbouiCOM.EditText txt_Prov;
        private SAPbouiCOM.LinkedButton lnk_Prov;
        private SAPbouiCOM.StaticText lbl_nProv;
        private SAPbouiCOM.StaticText lbl_Status;
        private SAPbouiCOM.ComboBox cbo_Status;
        private SAPbouiCOM.StaticText lbl_agidp;
        private SAPbouiCOM.EditText txt_agidp;
        private SAPbouiCOM.StaticText lbl_agral;
        private SAPbouiCOM.EditText txt_agral;
        private SAPbouiCOM.StaticText lbl_mdfrom;
        private SAPbouiCOM.EditText txt_mdfrom;
        private SAPbouiCOM.StaticText lbl_mdto;
        private SAPbouiCOM.EditText txt_mdto;
        private SAPbouiCOM.StaticText lbl_ocde;
        private SAPbouiCOM.EditText txt_ocde;
        private SAPbouiCOM.StaticText lbl_ocidp;
        private SAPbouiCOM.EditText txt_ocidp;
        private SAPbouiCOM.Button btn_Buscar;
        private SAPbouiCOM.Matrix mtx_multas;
        private SAPbouiCOM.StaticText lbl_docS;
        private SAPbouiCOM.ComboBox cbo_docS;
        private SAPbouiCOM.CheckBox chk_Cancel;
        #endregion

        #region Initializers
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Cancel = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.lbl_Prov = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Prov").Specific));
            this.txt_Prov = ((SAPbouiCOM.EditText)(this.GetItem("txt_Prov").Specific));
            this.txt_Prov.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txt_Prov_ChooseFromListAfter);
            this.lnk_Prov = ((SAPbouiCOM.LinkedButton)(this.GetItem("lnk_Prov").Specific));
            this.lbl_Status = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Status").Specific));
            this.cbo_Status = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_Status").Specific));
            this.lbl_agidp = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_agidp").Specific));
            this.txt_agidp = ((SAPbouiCOM.EditText)(this.GetItem("txt_agidp").Specific));
            this.lbl_agral = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_agral").Specific));
            this.txt_agral = ((SAPbouiCOM.EditText)(this.GetItem("txt_agral").Specific));
            this.lbl_mdfrom = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_mdfrom").Specific));
            this.txt_mdfrom = ((SAPbouiCOM.EditText)(this.GetItem("txt_mdfrom").Specific));
            this.lbl_mdto = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_mdto").Specific));
            this.txt_mdto = ((SAPbouiCOM.EditText)(this.GetItem("txt_mdto").Specific));
            this.lbl_ocde = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ocde").Specific));
            this.txt_ocde = ((SAPbouiCOM.EditText)(this.GetItem("txt_ocde").Specific));
            this.lbl_ocidp = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ocidp").Specific));
            this.txt_ocidp = ((SAPbouiCOM.EditText)(this.GetItem("txt_ocidp").Specific));
            this.btn_Buscar = ((SAPbouiCOM.Button)(this.GetItem("btn_Buscar").Specific));
            this.btn_Buscar.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.btn_Buscar_ClickAfter);
            this.mtx_multas = ((SAPbouiCOM.Matrix)(this.GetItem("mtx_multas").Specific));
            this.mtx_multas.LinkPressedAfter += new SAPbouiCOM._IMatrixEvents_LinkPressedAfterEventHandler(this.mtx_multas_LinkPressedAfter);
            this.lbl_nProv = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nProv").Specific));
            this.lbl_docS = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_docS").Specific));
            this.cbo_docS = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_docS").Specific));
            this.chk_Cancel = ((SAPbouiCOM.CheckBox)(this.GetItem("chk_Cancel").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private void OnCustomInitialize()
        {
            this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS").Query();
            InitializeCLFs();
            LoadComboBoxes();
            this.mtx_multas.AutoResizeColumns();
        }
        #endregion

        #region Events
        private void txt_Prov_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg oCFLEvent = null;
            try
            {
                oCFLEvent = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                if (oCFLEvent.SelectedObjects != null && oCFLEvent.SelectedObjects.Rows.Count > 0)
                {
                    SAPbouiCOM.DataTable oDT = null;
                    SAPbouiCOM.ChooseFromList oCLF = null;
                    SAPbouiCOM.Conditions oCons = null;
                    SAPbouiCOM.Condition oCon = null;

                    oDT = oCFLEvent.SelectedObjects;
                    this.UIAPIRawForm.DataSources.UserDataSources.Item("ud_Prov").Value = oDT.GetValue("CardCode", 0).ToString().Trim();
                    this.lbl_nProv.Caption = oDT.GetValue("CardName", 0).ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.MultaListado.cs > txt_Prov_ChooseFromListAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void btn_Buscar_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            try
            {
                this.UIAPIRawForm.Freeze(true);

                if (!string.IsNullOrEmpty(this.txt_mdfrom.Value) && !string.IsNullOrEmpty(this.txt_mdto.Value))
                {

                    oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_C");

                    oConds = new SAPbouiCOM.Conditions();

                    oCond = oConds.Add();
                    oCond.Alias = "DocEntry";
                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_NOT_NULL;

                    if (!string.IsNullOrEmpty(this.txt_Prov.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_CardCode";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.txt_Prov.Value;
                    }

                    if (this.cbo_Status.Selected != null && !string.IsNullOrEmpty(this.cbo_Status.Selected.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_Status";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.cbo_Status.Selected.Value;
                    }

                    if (this.cbo_docS.Selected != null && !string.IsNullOrEmpty(this.cbo_docS.Selected.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "Status";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.cbo_docS.Selected.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_mdfrom.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "CreateDate";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_GRATER_EQUAL;
                        oCond.CondVal = this.txt_mdfrom.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_mdto.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "CreateDate";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_LESS_EQUAL;
                        oCond.CondVal = this.txt_mdto.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_agidp.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_idlicAG";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.txt_agidp.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_agral.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_resadjAG";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.txt_agral.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_ocde.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_DocNumOC";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.txt_ocde.Value;
                    }

                    if (!string.IsNullOrEmpty(this.txt_ocidp.Value))
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "U_idptlOC";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = this.txt_ocidp.Value;
                    }

                    if (this.chk_Cancel.Checked)
                    {
                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        oCond = oConds.Add();
                        oCond.Alias = "Canceled";
                        oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        oCond.CondVal = "Y";
                    }

                    oDBDS.Query(oConds);
                    this.mtx_multas.LoadFromDataSource();
                    for (int i = 1; i <= this.mtx_multas.RowCount; i++)
                    {
                        ((SAPbouiCOM.EditText)this.mtx_multas.Columns.Item("#").Cells.Item(i).Specific).Value = i.ToString();
                    }
                    this.mtx_multas.AutoResizeColumns();
                    this.UIAPIRawForm.DataSources.UserDataSources.Item("#").Value = "";
                }
                else
                {
                    Application.SBO_Application.MessageBox("Los campos \"Multa F. Desde\" y \"Multa F. Hasta\" son obligatorios");
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.MultaListado.cs > btn_Buscar_ClickAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                this.UIAPIRawForm.Freeze(false);
            }

        }

        private void mtx_multas_LinkPressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            Multa oMulta = null;
            SAPbouiCOM.Form oForm = null;
            try 
            {
                Application.SBO_Application.StatusBar.SetText("Cargando formulario de Multas...", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                try
                {
                    Application.SBO_Application.Forms.GetForm("Multas.Forms.Multa", 0).Select();
                    oForm = Application.SBO_Application.Forms.GetForm("Multas.Forms.Multa", 0);
                    oForm.Close();
                    oMulta = new Multa();
                    oMulta.Show();
                }
                catch
                {
                    oMulta = new Multa();
                    oMulta.Show();
                }

                oForm = Application.SBO_Application.Forms.GetForm("Multas.Forms.Multa", 0);
                oForm.Freeze(true);
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_FIND_MODE;
                oForm.Items.Item("txt_NMulta").Enabled = true;
                ((SAPbouiCOM.EditText)oForm.Items.Item("txt_NMulta").Specific).Value = ((SAPbouiCOM.EditText)this.mtx_multas.Columns.Item("nromulta").Cells.Item(pVal.Row).Specific).Value;
                oForm.Items.Item("1").Click();
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.MultaListado.cs > mtx_multas_LinkPressedAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                oForm.Freeze(false);
                Application.SBO_Application.StatusBar.SetText("C", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_None);
            }

        }
        #endregion

        #region Methods
        private void InitializeCLFs()
        {
            SAPbouiCOM.ChooseFromList oCLF = null;
            SAPbouiCOM.Conditions oCons = null;
            SAPbouiCOM.Condition oCon = null;
            try
            {
                #region clf_Prov
                oCLF = this.UIAPIRawForm.ChooseFromLists.Item("clf_Prov");
                oCons = oCLF.GetConditions();
                oCon = oCons.Add();
                oCon.Alias = "CardType";
                oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCon.CondVal = "S";
                oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                oCon = oCons.Add();
                oCon.Alias = "GroupCode";
                oCon.Operation = SAPbouiCOM.BoConditionOperation.co_NOT_EQUAL;
                oCon.CondVal = "325";
                oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                oCon = oCons.Add();
                oCon.Alias = "ValidFor";
                oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCon.CondVal = "Y";

                oCLF.SetConditions(oCons);
                #endregion

            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.MultaListado.cs > InitializeCLFs(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }
        private void LoadComboBoxes()
        {
            SAPbouiCOM.DBDataSource oDBS = null;
            try
            {
                #region Cbo_Status
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS");
                if (oDBS.Size > 0)
                {
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.cbo_Status.ValidValues.Add(oDBS.GetValue("Code", i).Trim(), oDBS.GetValue("Name", i).Trim());
                    }
                }
                oDBS = null;
                #endregion

                #region Cbo_docS
                this.cbo_docS.ValidValues.Add("", "");
                this.cbo_docS.ValidValues.Add("O", "Abierto");
                this.cbo_docS.ValidValues.Add("C", "Cerrado");
                this.cbo_docS.Select("");
                oDBS = null;
                #endregion

                #region mtx_action.status
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS");
                if (oDBS.Size > 0)
                {
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.mtx_multas.Columns.Item("status").ValidValues.Add(oDBS.GetValue("Code", i).Trim(), oDBS.GetValue("Name", i).Trim());
                    }
                }
                oDBS = null;
                #endregion
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.MultaListado.cs > LoadComboBoxes(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }
        #endregion
    }
}
