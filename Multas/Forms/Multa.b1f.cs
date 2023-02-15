using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace Multas.Forms
{
    [FormAttribute("Multas.Forms.Multa", "Forms/Multa.b1f")]
    class Multa : UserFormBase
    {
        #region Properties
        public static string rightClickMenuId = "";
        #endregion

        #region Constructor
        public Multa()
        {
        }
        #endregion

        #region UI Components
        private SAPbouiCOM.Button btn_ok;
        private SAPbouiCOM.Button btn_close;
        private SAPbouiCOM.StaticText lbl_NMulta;
        private SAPbouiCOM.EditText txt_NMulta;
        private SAPbouiCOM.StaticText lbl_CDate;
        private SAPbouiCOM.EditText txt_CDate;
        private SAPbouiCOM.StaticText lbl_Status;
        private SAPbouiCOM.ComboBox cbo_Status;
        private SAPbouiCOM.StaticText lbl_Prov;
        private SAPbouiCOM.EditText txt_Prov;
        private SAPbouiCOM.StaticText lbl_Rut;
        private SAPbouiCOM.EditText txt_Rut;
        private SAPbouiCOM.StaticText lbl_NProv;
        private SAPbouiCOM.EditText txt_NProv;
        private SAPbouiCOM.LinkedButton lnk_Prov;
        private SAPbouiCOM.StaticText lbl_AG;
        private SAPbouiCOM.EditText txt_AG;
        private SAPbouiCOM.LinkedButton lnk_OOAT;
        private SAPbouiCOM.StaticText lbl_agidp;
        private SAPbouiCOM.EditText txt_agidp;
        private SAPbouiCOM.StaticText lbl_agral;
        private SAPbouiCOM.EditText txt_agral;
        private SAPbouiCOM.StaticText lbl_agEndD;
        private SAPbouiCOM.EditText txt_agEndD;
        private SAPbouiCOM.EditText txt_cflAG;
        private SAPbouiCOM.StaticText lbl_OC;
        private SAPbouiCOM.EditText txt_OC;
        private SAPbouiCOM.LinkedButton lnk_OC;
        private SAPbouiCOM.EditText txt_OCDE;
        private SAPbouiCOM.StaticText lbl_ocidp;
        private SAPbouiCOM.EditText txt_ocidp;
        private SAPbouiCOM.StaticText lbl_octd;
        private SAPbouiCOM.EditText txt_octd;
        private SAPbouiCOM.StaticText lbl_ocdd;
        private SAPbouiCOM.EditText txt_ocdd;
        private SAPbouiCOM.StaticText lbl_ValorM;
        private SAPbouiCOM.EditText txt_ValorM;
        private SAPbouiCOM.StaticText lbl_motive;
        private SAPbouiCOM.EditText txt_motive;
        private SAPbouiCOM.Folder f_General;
        private SAPbouiCOM.Folder f_oc;
        private SAPbouiCOM.Folder f_Acciones;
        private SAPbouiCOM.StaticText lbl_GarVen;
        private SAPbouiCOM.ComboBox cbo_GarVen;
        private SAPbouiCOM.StaticText lbl_dcGar;
        private SAPbouiCOM.EditText txt_dcGar;
        private SAPbouiCOM.StaticText lbl_fvbg;
        private SAPbouiCOM.EditText txt_fvbg;
        private SAPbouiCOM.StaticText lbl_nrcg;
        private SAPbouiCOM.EditText txt_nrcg;
        private SAPbouiCOM.StaticText lbl_frcg;
        private SAPbouiCOM.EditText txt_frcg;
        private SAPbouiCOM.StaticText lbl_novg;
        private SAPbouiCOM.EditText txt_novg; 
        private SAPbouiCOM.StaticText lbl_fodcg;
        private SAPbouiCOM.EditText txt_fodcg;
        private SAPbouiCOM.StaticText lbl_nim;
        private SAPbouiCOM.EditText txt_nim;
        private SAPbouiCOM.StaticText lbl_fim;
        private SAPbouiCOM.EditText txt_fim;
        private SAPbouiCOM.StaticText lbl_fca;
        private SAPbouiCOM.EditText txt_fca;
        private SAPbouiCOM.StaticText lbl_feqdn;
        private SAPbouiCOM.EditText txt_feqdn;
        private SAPbouiCOM.StaticText lbl_idnccp;
        private SAPbouiCOM.EditText txt_idnccp;
        private SAPbouiCOM.StaticText lbl_fnpi;
        private SAPbouiCOM.EditText txt_fnpi;
        private SAPbouiCOM.StaticText lbl_desPro;
        private SAPbouiCOM.ComboBox cbo_desPro;
        private SAPbouiCOM.StaticText lbl_fdprov;
        private SAPbouiCOM.EditText txt_fdprov;
        private SAPbouiCOM.StaticText lbl_nosra;
        private SAPbouiCOM.EditText txt_nosra;
        private SAPbouiCOM.StaticText lbl_fosra;
        private SAPbouiCOM.EditText txt_fosra;
        private SAPbouiCOM.StaticText lbl_nres;
        private SAPbouiCOM.EditText txt_nres;
        private SAPbouiCOM.StaticText lbl_fres;
        private SAPbouiCOM.EditText txt_fres;
        private SAPbouiCOM.StaticText lbl_desc;
        private SAPbouiCOM.ComboBox cbo_desc;
        private SAPbouiCOM.StaticText lbl_feqdd;
        private SAPbouiCOM.EditText txt_feqdd;
        private SAPbouiCOM.StaticText lbl_inccpr;
        private SAPbouiCOM.EditText txt_inccpr;
        private SAPbouiCOM.StaticText lbl_fnpr;
        private SAPbouiCOM.EditText txt_fnpr;
        private SAPbouiCOM.StaticText lbl_ppsc;
        private SAPbouiCOM.EditText txt_ppsc;
        private SAPbouiCOM.StaticText lbl_epr;
        private SAPbouiCOM.ComboBox cbo_epr;
        private SAPbouiCOM.StaticText lbl_rrprov;
        private SAPbouiCOM.ComboBox cbo_rrprov;
        private SAPbouiCOM.StaticText lbl_frhrr;
        private SAPbouiCOM.EditText txt_frhrr;
        private SAPbouiCOM.StaticText lbl_frarr;
        private SAPbouiCOM.EditText txt_frarr;
        private SAPbouiCOM.StaticText lbl_nrrr;
        private SAPbouiCOM.EditText txt_nrrr;
        private SAPbouiCOM.StaticText lbl_frearr;
        private SAPbouiCOM.EditText txt_frearr;
        private SAPbouiCOM.StaticText lbl_rra;
        private SAPbouiCOM.ComboBox cbo_rra;
        private SAPbouiCOM.StaticText lbl_rracog;
        private SAPbouiCOM.EditText txt_rracog;
        private SAPbouiCOM.StaticText lbl_feqdrr;
        private SAPbouiCOM.EditText txt_feqdrr;
        private SAPbouiCOM.StaticText lbl_fpm;
        private SAPbouiCOM.EditText txt_fpm;
        private SAPbouiCOM.StaticText lbl_nosrcg;
        private SAPbouiCOM.EditText txt_nosrcg;
        private SAPbouiCOM.StaticText lbl_fosrcg;
        private SAPbouiCOM.EditText txt_fosrcg;
        private SAPbouiCOM.Matrix mtx_Items;
        private SAPbouiCOM.Matrix mtx_action;
        private SAPbouiCOM.StaticText lbl_docS;
        private SAPbouiCOM.ComboBox cbo_docS;
        private SAPbouiCOM.CheckBox chk_cancel;
        private SAPbouiCOM.StaticText lbl_tipoM;
        private SAPbouiCOM.ComboBox cbo_tipoM;
        private SAPbouiCOM.StaticText lbl_dateR;
        private SAPbouiCOM.EditText txt_dateR;
        private SAPbouiCOM.StaticText lbl_valorR;
        private SAPbouiCOM.EditText txt_valorR;
        private SAPbouiCOM.StaticText lbl_adminC;
        private SAPbouiCOM.EditText txt_adminC;
        private SAPbouiCOM.StaticText lbl_fvc;
        private SAPbouiCOM.EditText txt_fvc;
        private SAPbouiCOM.StaticText lbl_inccpR;
        private SAPbouiCOM.EditText txt_inccpR;
        private SAPbouiCOM.StaticText lbl_fnpR;
        private SAPbouiCOM.EditText txt_fnpR;
        private SAPbouiCOM.StaticText lbl_fedr;
        private SAPbouiCOM.EditText txt_fedr;
        #endregion

        #region Initializers
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.btn_ok = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.btn_close = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.lbl_NMulta = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_NMulta").Specific));
            this.txt_NMulta = ((SAPbouiCOM.EditText)(this.GetItem("txt_NMulta").Specific));
            this.lbl_CDate = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_CDate").Specific));
            this.txt_CDate = ((SAPbouiCOM.EditText)(this.GetItem("txt_CDate").Specific));
            this.lbl_Status = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Status").Specific));
            this.cbo_Status = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_Status").Specific));
            this.cbo_Status.ComboSelectAfter += new SAPbouiCOM._IComboBoxEvents_ComboSelectAfterEventHandler(this.cbo_Status_ComboSelectAfter);
            this.lbl_Prov = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Prov").Specific));
            this.txt_Prov = ((SAPbouiCOM.EditText)(this.GetItem("txt_Prov").Specific));
            this.txt_Prov.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txt_Prov_ChooseFromListAfter);
            this.lbl_Rut = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_Rut").Specific));
            this.txt_Rut = ((SAPbouiCOM.EditText)(this.GetItem("txt_Rut").Specific));
            this.lbl_NProv = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_NProv").Specific));
            this.txt_NProv = ((SAPbouiCOM.EditText)(this.GetItem("txt_NProv").Specific));
            this.lnk_Prov = ((SAPbouiCOM.LinkedButton)(this.GetItem("lnk_Prov").Specific));
            this.lbl_AG = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_AG").Specific));
            this.txt_AG = ((SAPbouiCOM.EditText)(this.GetItem("txt_AG").Specific));
            this.txt_AG.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txt_AG_ChooseFromListAfter);
            this.lnk_OOAT = ((SAPbouiCOM.LinkedButton)(this.GetItem("lnk_OOAT").Specific));
            this.lbl_agidp = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_agidp").Specific));
            this.txt_agidp = ((SAPbouiCOM.EditText)(this.GetItem("txt_agidp").Specific));
            this.lbl_agral = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_agral").Specific));
            this.txt_agral = ((SAPbouiCOM.EditText)(this.GetItem("txt_agral").Specific));
            this.lbl_agEndD = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_agEndD").Specific));
            this.txt_agEndD = ((SAPbouiCOM.EditText)(this.GetItem("txt_agEndD").Specific));
            this.txt_cflAG = ((SAPbouiCOM.EditText)(this.GetItem("txt_cflAG").Specific));
            this.lbl_OC = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_OC").Specific));
            this.txt_OC = ((SAPbouiCOM.EditText)(this.GetItem("txt_OC").Specific));
            this.txt_OC.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txt_OC_ChooseFromListAfter);
            this.lnk_OC = ((SAPbouiCOM.LinkedButton)(this.GetItem("lnk_OC").Specific));
            this.txt_OCDE = ((SAPbouiCOM.EditText)(this.GetItem("txt_OCDE").Specific));
            this.lbl_ocidp = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ocidp").Specific));
            this.txt_ocidp = ((SAPbouiCOM.EditText)(this.GetItem("txt_ocidp").Specific));
            this.lbl_octd = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_octd").Specific));
            this.txt_octd = ((SAPbouiCOM.EditText)(this.GetItem("txt_octd").Specific));
            this.lbl_ocdd = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ocdd").Specific));
            this.txt_ocdd = ((SAPbouiCOM.EditText)(this.GetItem("txt_ocdd").Specific));
            this.lbl_ValorM = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ValorM").Specific));
            this.txt_ValorM = ((SAPbouiCOM.EditText)(this.GetItem("txt_ValorM").Specific));
            this.lbl_motive = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_motive").Specific));
            this.txt_motive = ((SAPbouiCOM.EditText)(this.GetItem("txt_motive").Specific));
            this.f_General = ((SAPbouiCOM.Folder)(this.GetItem("f_General").Specific));
            this.f_oc = ((SAPbouiCOM.Folder)(this.GetItem("f_oc").Specific));
            this.f_Acciones = ((SAPbouiCOM.Folder)(this.GetItem("f_Acciones").Specific));
            this.lbl_GarVen = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_GarVen").Specific));
            this.cbo_GarVen = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_GarVen").Specific));
            this.lbl_dcGar = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_dcGar").Specific));
            this.txt_dcGar = ((SAPbouiCOM.EditText)(this.GetItem("txt_dcGar").Specific));
            this.lbl_fvbg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fvbg").Specific));
            this.txt_fvbg = ((SAPbouiCOM.EditText)(this.GetItem("txt_fvbg").Specific));
            this.lbl_nrcg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nrcg").Specific));
            this.txt_nrcg = ((SAPbouiCOM.EditText)(this.GetItem("txt_nrcg").Specific));
            this.lbl_frcg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_frcg").Specific));
            this.txt_frcg = ((SAPbouiCOM.EditText)(this.GetItem("txt_frcg").Specific));
            this.lbl_novg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_novg").Specific));
            this.txt_novg = ((SAPbouiCOM.EditText)(this.GetItem("txt_novg").Specific));
            this.lbl_fodcg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fodcg").Specific));
            this.txt_fodcg = ((SAPbouiCOM.EditText)(this.GetItem("txt_fodcg").Specific));
            this.lbl_nim = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nim").Specific));
            this.txt_nim = ((SAPbouiCOM.EditText)(this.GetItem("txt_nim").Specific));
            this.lbl_fim = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fim").Specific));
            this.txt_fim = ((SAPbouiCOM.EditText)(this.GetItem("txt_fim").Specific));
            this.lbl_fca = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fca").Specific));
            this.txt_fca = ((SAPbouiCOM.EditText)(this.GetItem("txt_fca").Specific));
            this.lbl_feqdn = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_feqdn").Specific));
            this.txt_feqdn = ((SAPbouiCOM.EditText)(this.GetItem("txt_feqdn").Specific));
            this.lbl_idnccp = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_idnccp").Specific));
            this.txt_idnccp = ((SAPbouiCOM.EditText)(this.GetItem("txt_idnccp").Specific));
            this.lbl_fnpi = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fnpi").Specific));
            this.txt_fnpi = ((SAPbouiCOM.EditText)(this.GetItem("txt_fnpi").Specific));
            this.lbl_desPro = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_desPro").Specific));
            this.cbo_desPro = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_desPro").Specific));
            this.lbl_fdprov = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fdprov").Specific));
            this.txt_fdprov = ((SAPbouiCOM.EditText)(this.GetItem("txt_fdprov").Specific));
            this.lbl_nosra = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nosra").Specific));
            this.txt_nosra = ((SAPbouiCOM.EditText)(this.GetItem("txt_nosra").Specific));
            this.lbl_fosra = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fosra").Specific));
            this.txt_fosra = ((SAPbouiCOM.EditText)(this.GetItem("txt_fosra").Specific));
            this.lbl_nres = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nres").Specific));
            this.txt_nres = ((SAPbouiCOM.EditText)(this.GetItem("txt_nres").Specific));
            this.lbl_fres = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fres").Specific));
            this.txt_fres = ((SAPbouiCOM.EditText)(this.GetItem("txt_fres").Specific));
            this.lbl_desc = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_desc").Specific));
            this.cbo_desc = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_desc").Specific));
            this.lbl_feqdd = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_feqdd").Specific));
            this.txt_feqdd = ((SAPbouiCOM.EditText)(this.GetItem("txt_feqdd").Specific));
            this.lbl_inccpr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_inccpr").Specific));
            this.txt_inccpr = ((SAPbouiCOM.EditText)(this.GetItem("txt_inccpr").Specific));
            this.lbl_fnpr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fnpr").Specific));
            this.txt_fnpr = ((SAPbouiCOM.EditText)(this.GetItem("txt_fnpr").Specific));
            this.lbl_ppsc = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_ppsc").Specific));
            this.txt_ppsc = ((SAPbouiCOM.EditText)(this.GetItem("txt_ppsc").Specific));
            this.lbl_epr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_epr").Specific));
            this.cbo_epr = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_epr").Specific));
            this.lbl_rrprov = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_rrprov").Specific));
            this.cbo_rrprov = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_rrprov").Specific));
            this.lbl_frhrr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_frhrr").Specific));
            this.txt_frhrr = ((SAPbouiCOM.EditText)(this.GetItem("txt_frhrr").Specific));
            this.lbl_frarr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_frarr").Specific));
            this.txt_frarr = ((SAPbouiCOM.EditText)(this.GetItem("txt_frarr").Specific));
            this.lbl_nrrr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nrrr").Specific));
            this.txt_nrrr = ((SAPbouiCOM.EditText)(this.GetItem("txt_nrrr").Specific));
            this.lbl_frearr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_frearr").Specific));
            this.txt_frearr = ((SAPbouiCOM.EditText)(this.GetItem("txt_frearr").Specific));
            this.lbl_rra = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_rra").Specific));
            this.cbo_rra = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_rra").Specific));
            this.lbl_rracog = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_rracog").Specific));
            this.txt_rracog = ((SAPbouiCOM.EditText)(this.GetItem("txt_rracog").Specific));
            this.lbl_feqdrr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_feqdrr").Specific));
            this.txt_feqdrr = ((SAPbouiCOM.EditText)(this.GetItem("txt_feqdrr").Specific));
            this.lbl_fpm = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fpm").Specific));
            this.txt_fpm = ((SAPbouiCOM.EditText)(this.GetItem("txt_fpm").Specific));
            this.lbl_nosrcg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_nosrcg").Specific));
            this.txt_nosrcg = ((SAPbouiCOM.EditText)(this.GetItem("txt_nosrcg").Specific));
            this.lbl_fosrcg = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fosrcg").Specific));
            this.txt_fosrcg = ((SAPbouiCOM.EditText)(this.GetItem("txt_fosrcg").Specific));
            this.mtx_Items = ((SAPbouiCOM.Matrix)(this.GetItem("mtx_Items").Specific));
            this.mtx_action = ((SAPbouiCOM.Matrix)(this.GetItem("mtx_action").Specific));
            this.mtx_action.MatrixLoadAfter += new SAPbouiCOM._IMatrixEvents_MatrixLoadAfterEventHandler(this.mtx_action_MatrixLoadAfter);
            this.mtx_action.ComboSelectAfter += new SAPbouiCOM._IMatrixEvents_ComboSelectAfterEventHandler(this.mtx_action_ComboSelectAfter);
            this.lbl_docS = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_docS").Specific));
            this.cbo_docS = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_docS").Specific));
            this.chk_cancel = ((SAPbouiCOM.CheckBox)(this.GetItem("chk_cancel").Specific));
            this.lbl_tipoM = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_tipoM").Specific));
            this.cbo_tipoM = ((SAPbouiCOM.ComboBox)(this.GetItem("cbo_tipoM").Specific));
            this.lbl_dateR = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_dateR").Specific));
            this.txt_dateR = ((SAPbouiCOM.EditText)(this.GetItem("txt_dateR").Specific));
            this.lbl_valorR = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_valorR").Specific));
            this.txt_valorR = ((SAPbouiCOM.EditText)(this.GetItem("txt_valorR").Specific));
            this.lbl_adminC = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_adminC").Specific));
            this.txt_adminC = ((SAPbouiCOM.EditText)(this.GetItem("txt_adminC").Specific));
            this.lbl_fvc = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fvc").Specific));
            this.txt_fvc = ((SAPbouiCOM.EditText)(this.GetItem("txt_fvc").Specific));
            this.lbl_inccpR = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_inccpR").Specific));
            this.txt_inccpR = ((SAPbouiCOM.EditText)(this.GetItem("txt_inccpR").Specific));
            this.lbl_fnpR = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fnpR").Specific));
            this.txt_fnpR = ((SAPbouiCOM.EditText)(this.GetItem("txt_fnpR").Specific));
            this.lbl_fedr = ((SAPbouiCOM.StaticText)(this.GetItem("lbl_fedr").Specific));
            this.txt_fedr = ((SAPbouiCOM.EditText)(this.GetItem("txt_fedr").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.RightClickAfter += new SAPbouiCOM.Framework.FormBase.RightClickAfterHandler(this.Form_RightClickAfter);
            this.DataLoadAfter += new SAPbouiCOM.Framework.FormBase.DataLoadAfterHandler(this.Form_DataLoadAfter);
            this.DataAddBefore += new SAPbouiCOM.Framework.FormBase.DataAddBeforeHandler(this.Form_DataAddBefore);
            this.DataUpdateBefore += new DataUpdateBeforeHandler(this.Form_DataUpdateBefore);

        }

        private void OnCustomInitialize()
        {
            try
            {
                this.UIAPIRawForm.EnableMenu("1292", true);
                this.UIAPIRawForm.EnableMenu("1293", true);
                this.UIAPIRawForm.EnableMenu("1283", false);
                this.UIAPIRawForm.EnableMenu("1284", true);
                this.UIAPIRawForm.EnableMenu("1286", true);
                this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS").Query();
                this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_DESCARGO").Query();
                this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_DEFACCION").Query();
                this.UIAPIRawForm.DataSources.DBDataSources.Item("OCRN").Query();
                this.UIAPIRawForm.Items.Item("txt_cflAG").Width = 1;
                this.UIAPIRawForm.Items.Item("txt_cflAG").Height = 1;
                this.UIAPIRawForm.Items.Item("txt_OCDE").Width = 1;
                this.UIAPIRawForm.Items.Item("txt_OCDE").Height = 1;
                this.f_General.Select();
                LoadComboBoxes();
                InitializeCLFs();
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > OnCustomInitialize(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }

        }
        #endregion

        #region Events
        private void cbo_Status_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.DBDataSource oDBS = null;
            string selectedValue = "";
            try
            {
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS");
                selectedValue = ((dynamic)sboObject).Value;
                for(int i = 0; i < oDBS.Size; i++)
                {
                    if(oDBS.GetValue("Name", i).Trim().Equals(selectedValue))
                    {
                        selectedValue = oDBS.GetValue("Code", i).Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > cbo_Status_ComboSelectAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void Form_DataLoadAfter(ref SAPbouiCOM.BusinessObjectInfo pVal)
        {
            try
            {
                switch (pVal.BeforeAction)
                {
                    case false:
                        ManageMenuAction();
                        break;
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > Form_DataLoadAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);

            }
        }

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
                    txt_Rut.Value = oDT.GetValue("LicTradNum", 0).ToString().Trim();
                    txt_NProv.Value = oDT.GetValue("CardName", 0).ToString().Trim();

                    #region clf_OOAT
                    oCLF = null;
                    oCLF = this.UIAPIRawForm.ChooseFromLists.Item("clf_OOAT");
                    oCLF.SetConditions(null);
                    oCons = oCLF.GetConditions();
                    oCon = oCons.Add();
                    oCon.Alias = "BpCode";
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCon.CondVal = this.txt_Prov.Value;
                    oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                    oCon = oCons.Add();
                    oCon.Alias = "Status";
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCon.CondVal = "A";
                    oCLF.SetConditions(oCons);
                    #endregion

                    #region clf_OPOR
                    oCLF = null;
                    oCLF = this.UIAPIRawForm.ChooseFromLists.Item("clf_OPOR");
                    oCLF.SetConditions(null);
                    oCons = oCLF.GetConditions();
                    oCon = oCons.Add();
                    oCon.Alias = "CardCode";
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCon.CondVal = this.txt_Prov.Value;
                    oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                    oCon = oCons.Add();
                    oCon.Alias = "DocDate";
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_GRATER_EQUAL;
                    oCon.CondVal = DateTime.Now.AddYears(-1).ToString("yyyyMMdd");
                    oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                    oCon = oCons.Add();
                    oCon.Alias = "CANCELED";
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCon.CondVal = "N";

                    oCLF.SetConditions(oCons);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > txt_Prov_ChooseFromListAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void txt_AG_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg oCFLEvent = null;
            SAPbouiCOM.DataTable oDT = null;
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            try
            {
                oCFLEvent = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                if (oCFLEvent.SelectedObjects != null && oCFLEvent.SelectedObjects.Rows.Count > 0)
                {
                    oDT = oCFLEvent.SelectedObjects;
                    oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("OOAT");
                    oConds = new SAPbouiCOM.Conditions();
                    oCond = oConds.Add();
                    oCond.Alias = "Number";
                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCond.CondVal = oDT.GetValue("Number",0).ToString().Trim();
                    oDBDS.Query(oConds);
                    if(oDBDS.Size > 0)
                    {
                        txt_agidp.Value = oDBDS.GetValue("U_LG_idlic", 0).Trim();
                        txt_agral.Value = oDBDS.GetValue("U_LG_resadj", 0).Trim();
                        txt_agEndD.Value = oDBDS.GetValue("EndDate", 0).Trim();
                        txt_cflAG.Value = oDBDS.GetValue("AbsId", 0).Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > txt_AG_ChooseFromListAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void txt_OC_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg oCFLEvent = null;
            SAPbouiCOM.DataTable oDT = null;
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            try
            {
                oCFLEvent = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                if (oCFLEvent.SelectedObjects != null && oCFLEvent.SelectedObjects.Rows.Count > 0)
                {
                    oDT = oCFLEvent.SelectedObjects;
                    oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("OPOR");
                    oConds = new SAPbouiCOM.Conditions();
                    oCond = oConds.Add();
                    oCond.Alias = "DocNum";
                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCond.CondVal = oDT.GetValue("DocNum", 0).ToString().Trim();
                    oDBDS.Query(oConds);
                    if (oDBDS.Size > 0)
                    {
                        txt_OCDE.Value = oDBDS.GetValue("DocEntry", 0).Trim();
                        txt_ocidp.Value = oDBDS.GetValue("U_LG_idptl", 0).Trim();
                        txt_octd.Value = oDBDS.GetValue("TaxDate", 0).Trim();
                        txt_ocdd.Value = oDBDS.GetValue("DocDueDate", 0).Trim();
                        LoadItemMatrix();
                    }
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > txt_OC_ChooseFromListAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void Form_RightClickAfter(ref SAPbouiCOM.ContextMenuInfo eventInfo)
        {
            SAPbouiCOM.DBDataSource oMatrixDBDS = null;
            this.UIAPIRawForm.Freeze(true);
            try
            {
                switch (rightClickMenuId)
                {
                    case "1292":
                        switch (eventInfo.ItemUID)
                        {
                            case "mtx_action":
                                this.mtx_action.AddRow();
                                this.mtx_action.ClearRowData(this.mtx_action.RowCount);
                                this.mtx_action.FlushToDataSource();
                                this.mtx_action.LoadFromDataSource();
                                ManageActionMatix();
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > Form_RightClickAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                this.UIAPIRawForm.Freeze(false);
                rightClickMenuId = "";
            }
        }

        private void mtx_action_ComboSelectAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.DBDataSource oMatrixDBDS = null;
            try
            {
                this.UIAPIRawForm.Freeze(true);
                oMatrixDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_ACCION");
                if (string.IsNullOrEmpty(oMatrixDBDS.GetValue("U_Date", pVal.Row - 1)))
                {
                    this.mtx_action.FlushToDataSource();
                    oMatrixDBDS.SetValue("U_Date", pVal.Row - 1, DateTime.Now.ToString("yyyyMMdd"));
                    oMatrixDBDS.SetValue("U_Time", pVal.Row - 1, DateTime.Now.ToString("HHmm"));
                    oMatrixDBDS.SetValue("U_UsuarioAccion", pVal.Row - 1, Application.SBO_Application.Company.UserName);
                    this.mtx_action.LoadFromDataSource();
                }

            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > mtx_action_ComboSelectAfter(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                this.UIAPIRawForm.Freeze(false);
            }
        }

        private void mtx_action_MatrixLoadAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            ManageActionMatix();

        }

        private void Form_DataAddBefore(ref SAPbouiCOM.BusinessObjectInfo pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            SAPbouiCOM.Form oForm = null;
            try
            {
                oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                if (oForm.DataSources.DBDataSources.Item("@ISC_MULTA_C").GetValue("U_Status", 0).Trim() != "1")
                {
                    BubbleEvent = false;
                    Application.SBO_Application.MessageBox("El campo \"Estatus\": debe tene el valor \"Pendiente\"");

                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > Form_DataAddBefore(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void Form_DataUpdateBefore(ref SAPbouiCOM.BusinessObjectInfo pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            SAPbouiCOM.Form oForm = null;
            try
            {
                oForm = Application.SBO_Application.Forms.Item(pVal.FormUID);
                if (rightClickMenuId == "1286")
                {
                    if (double.Parse(oForm.DataSources.DBDataSources.Item("@ISC_MULTA_C").GetValue("U_ValorMulta", 0).Trim()) == 0
                        || double.Parse(oForm.DataSources.DBDataSources.Item("@ISC_MULTA_C").GetValue("U_ValorMultaRef", 0).Trim()) == 0
                        || string.IsNullOrEmpty(oForm.DataSources.DBDataSources.Item("@ISC_MULTA_C").GetValue("U_fechaRefValor", 0).Trim())
                        )
                    {
                        rightClickMenuId = "";
                        BubbleEvent = false;
                        Application.SBO_Application.MessageBox("Para cerrar la Multa, los campos correspondiente al Valor de la multa no pueden estar vacios.");
                    }

                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > Form_DataUpdateBefore(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }
        #endregion

        #region Methods
        public static void ManageMenuAction(string menuId = "")
        {
            SAPbouiCOM.Form oForm = null;
            try 
            {
                oForm = Application.SBO_Application.Forms.ActiveForm;
                oForm.Freeze(true);
                switch (menuId)
                {
                    case "1281": //Search
                        #region Search
                        oForm.Items.Item("f_General").Click();
                        oForm.Items.Item("txt_NMulta").Enabled = true;
                        oForm.Items.Item("txt_CDate").Enabled = true;
                        oForm.Items.Item("cbo_Status").Enabled = true;
                        oForm.Items.Item("txt_adminC").Enabled = false;
                        oForm.Items.Item("txt_fvc").Enabled = false;
                        oForm.Items.Item("txt_Prov").Enabled = true;
                        oForm.Items.Item("txt_Rut").Enabled = true;
                        oForm.Items.Item("txt_NProv").Enabled = true;
                        oForm.Items.Item("txt_AG").Enabled = true;
                        oForm.Items.Item("txt_agidp").Enabled = true;
                        oForm.Items.Item("txt_agral").Enabled = true;
                        oForm.Items.Item("txt_OC").Enabled = true;
                        oForm.Items.Item("txt_ocidp").Enabled = true;
                        oForm.Items.Item("txt_motive").Enabled = false;
                        oForm.Items.Item("cbo_tipoM").Enabled = false;
                        oForm.Items.Item("txt_dateR").Enabled = false;
                        oForm.Items.Item("txt_ValorM").Enabled = false;
                        oForm.Items.Item("txt_valorR").Enabled = false;
                        oForm.Items.Item("cbo_GarVen").Enabled = false;
                        oForm.Items.Item("txt_dcGar").Enabled = false;
                        oForm.Items.Item("txt_fvbg").Enabled = false;
                        oForm.Items.Item("txt_nrcg").Enabled = false;
                        oForm.Items.Item("txt_frcg").Enabled = false;
                        oForm.Items.Item("txt_novg").Enabled = false;
                        oForm.Items.Item("txt_fodcg").Enabled = false;
                        oForm.Items.Item("txt_nim").Enabled = false;
                        oForm.Items.Item("txt_fim").Enabled = false;
                        oForm.Items.Item("txt_fca").Enabled = false;
                        oForm.Items.Item("txt_feqdn").Enabled = false;
                        oForm.Items.Item("txt_idnccp").Enabled = false;
                        oForm.Items.Item("txt_fnpi").Enabled = false;
                        oForm.Items.Item("cbo_desPro").Enabled = false;
                        oForm.Items.Item("txt_fdprov").Enabled = false;
                        oForm.Items.Item("txt_nosra").Enabled = false;
                        oForm.Items.Item("txt_fosra").Enabled = false;
                        oForm.Items.Item("txt_nres").Enabled = false;
                        oForm.Items.Item("txt_fres").Enabled = false;
                        oForm.Items.Item("cbo_desc").Enabled = false;
                        oForm.Items.Item("txt_feqdd").Enabled = false;
                        oForm.Items.Item("txt_inccpr").Enabled = false;
                        oForm.Items.Item("txt_fnpr").Enabled = false;
                        oForm.Items.Item("txt_ppsc").Enabled = false;
                        oForm.Items.Item("cbo_epr").Enabled = false;
                        oForm.Items.Item("txt_frhrr").Enabled = false;
                        oForm.Items.Item("cbo_rrprov").Enabled = false;
                        oForm.Items.Item("txt_frarr").Enabled = false;
                        oForm.Items.Item("txt_nrrr").Enabled = false;
                        oForm.Items.Item("txt_frearr").Enabled = false;
                        oForm.Items.Item("cbo_rra").Enabled = false;
                        oForm.Items.Item("txt_rracog").Enabled = false;
                        oForm.Items.Item("txt_feqdrr").Enabled = false;
                        oForm.Items.Item("txt_fpm").Enabled = false;
                        oForm.Items.Item("txt_nosrcg").Enabled = false;
                        oForm.Items.Item("txt_fosrcg").Enabled = false;
                        oForm.Items.Item("lbl_inccpR").Enabled = false;
                        oForm.Items.Item("txt_inccpR").Enabled = false;
                        oForm.Items.Item("lbl_fnpR").Enabled = false;
                        oForm.Items.Item("txt_fnpR").Enabled = false;
                        oForm.Items.Item("lbl_fedr").Enabled = false;
                        oForm.Items.Item("txt_fedr").Enabled = false;
                        oForm.Items.Item("mtx_action").Enabled = false;
                        #endregion
                        break;
                    case "1282": //New
                        #region New
                        oForm.Items.Item("f_General").Click();
                        oForm.Items.Item("txt_NMulta").Enabled = false;
                        oForm.Items.Item("txt_CDate").Enabled = false;
                        oForm.Items.Item("cbo_Status").Enabled = true;
                        oForm.Items.Item("txt_adminC").Enabled = true;
                        oForm.Items.Item("txt_fvc").Enabled = true;
                        oForm.Items.Item("txt_Prov").Enabled = true;
                        oForm.Items.Item("txt_Rut").Enabled = false;
                        oForm.Items.Item("txt_NProv").Enabled = false;
                        oForm.Items.Item("txt_AG").Enabled = true;
                        oForm.Items.Item("txt_agidp").Enabled = false;
                        oForm.Items.Item("txt_agral").Enabled = false;
                        oForm.Items.Item("txt_OC").Enabled = true;
                        oForm.Items.Item("txt_ocidp").Enabled = false;
                        oForm.Items.Item("txt_motive").Enabled = true;
                        oForm.Items.Item("cbo_tipoM").Enabled = true;
                        oForm.Items.Item("txt_dateR").Enabled = true;
                        oForm.Items.Item("txt_ValorM").Enabled = true;
                        oForm.Items.Item("txt_valorR").Enabled = true;
                        oForm.Items.Item("cbo_GarVen").Enabled = true;
                        oForm.Items.Item("txt_dcGar").Enabled = true;
                        oForm.Items.Item("txt_fvbg").Enabled = true;
                        oForm.Items.Item("txt_nrcg").Enabled = true;
                        oForm.Items.Item("txt_frcg").Enabled = true;
                        oForm.Items.Item("txt_novg").Enabled = true;
                        oForm.Items.Item("txt_fodcg").Enabled = true;
                        oForm.Items.Item("txt_nim").Enabled = true;
                        oForm.Items.Item("txt_fim").Enabled = true;
                        oForm.Items.Item("txt_fca").Enabled = true;
                        oForm.Items.Item("txt_feqdn").Enabled = true;
                        oForm.Items.Item("txt_idnccp").Enabled = true;
                        oForm.Items.Item("txt_fnpi").Enabled = true;
                        oForm.Items.Item("cbo_desPro").Enabled = true;
                        oForm.Items.Item("txt_fdprov").Enabled = true;
                        oForm.Items.Item("txt_nosra").Enabled = true;
                        oForm.Items.Item("txt_fosra").Enabled = true;
                        oForm.Items.Item("txt_nres").Enabled = true;
                        oForm.Items.Item("txt_fres").Enabled = true;
                        oForm.Items.Item("cbo_desc").Enabled = true;
                        oForm.Items.Item("txt_feqdd").Enabled = true;
                        oForm.Items.Item("txt_fnpr").Enabled = true;
                        oForm.Items.Item("txt_inccpr").Enabled = true;
                        oForm.Items.Item("txt_ppsc").Enabled = true;
                        oForm.Items.Item("cbo_epr").Enabled = true;
                        oForm.Items.Item("txt_frhrr").Enabled = true;
                        oForm.Items.Item("cbo_rrprov").Enabled = true;
                        oForm.Items.Item("txt_frarr").Enabled = true;
                        oForm.Items.Item("txt_nrrr").Enabled = true;
                        oForm.Items.Item("txt_frearr").Enabled = true;
                        oForm.Items.Item("cbo_rra").Enabled = true;
                        oForm.Items.Item("txt_rracog").Enabled = true;
                        oForm.Items.Item("txt_feqdrr").Enabled = true;
                        oForm.Items.Item("txt_fpm").Enabled = true;
                        oForm.Items.Item("txt_nosrcg").Enabled = true;
                        oForm.Items.Item("txt_fosrcg").Enabled = true;
                        oForm.Items.Item("lbl_inccpR").Enabled = true;
                        oForm.Items.Item("txt_inccpR").Enabled = true;
                        oForm.Items.Item("lbl_fnpR").Enabled = true;
                        oForm.Items.Item("txt_fnpR").Enabled = true;
                        oForm.Items.Item("lbl_fedr").Enabled = true;
                        oForm.Items.Item("txt_fedr").Enabled = true;
                        oForm.Items.Item("mtx_action").Enabled = true;
                        break;
                        #endregion
                    default: //Navigate
                        #region Navigate
                        if (oForm.DataSources.DBDataSources.Item("@ISC_MULTA_C").GetValue("Status", 0).Trim() == "C")
                        {
                            oForm.Items.Item("f_General").Click();
                            oForm.Items.Item("txt_NMulta").Enabled = false;
                            oForm.Items.Item("txt_CDate").Enabled = false;
                            oForm.Items.Item("cbo_Status").Enabled = false;
                            oForm.Items.Item("txt_adminC").Enabled = false;
                            oForm.Items.Item("txt_fvc").Enabled = false;
                            oForm.Items.Item("txt_Prov").Enabled = false;
                            oForm.Items.Item("txt_Rut").Enabled = false;
                            oForm.Items.Item("txt_NProv").Enabled = false;
                            oForm.Items.Item("txt_AG").Enabled = false;
                            oForm.Items.Item("txt_agidp").Enabled = false;
                            oForm.Items.Item("txt_agral").Enabled = false;
                            oForm.Items.Item("txt_OC").Enabled = false;
                            oForm.Items.Item("txt_ocidp").Enabled = false;
                            oForm.Items.Item("txt_motive").Enabled = false;
                            oForm.Items.Item("cbo_tipoM").Enabled = false;
                            oForm.Items.Item("txt_dateR").Enabled = false;
                            oForm.Items.Item("txt_ValorM").Enabled = false;
                            oForm.Items.Item("txt_valorR").Enabled = false;
                            oForm.Items.Item("cbo_GarVen").Enabled = false;
                            oForm.Items.Item("txt_dcGar").Enabled = false;
                            oForm.Items.Item("txt_fvbg").Enabled = false;
                            oForm.Items.Item("txt_nrcg").Enabled = false;
                            oForm.Items.Item("txt_frcg").Enabled = false;
                            oForm.Items.Item("txt_novg").Enabled = false;
                            oForm.Items.Item("txt_fodcg").Enabled = false;
                            oForm.Items.Item("txt_nim").Enabled = false;
                            oForm.Items.Item("txt_fim").Enabled = false;
                            oForm.Items.Item("txt_fca").Enabled = false;
                            oForm.Items.Item("txt_feqdn").Enabled = false;
                            oForm.Items.Item("txt_idnccp").Enabled = false;
                            oForm.Items.Item("txt_fnpi").Enabled = false;
                            oForm.Items.Item("cbo_desPro").Enabled = false;
                            oForm.Items.Item("txt_fdprov").Enabled = false;
                            oForm.Items.Item("txt_nosra").Enabled = false;
                            oForm.Items.Item("txt_fosra").Enabled = false;
                            oForm.Items.Item("txt_nres").Enabled = false;
                            oForm.Items.Item("txt_fres").Enabled = false;
                            oForm.Items.Item("cbo_desc").Enabled = false;
                            oForm.Items.Item("txt_feqdd").Enabled = false;
                            oForm.Items.Item("txt_inccpr").Enabled = false;
                            oForm.Items.Item("txt_fnpr").Enabled = false;
                            oForm.Items.Item("txt_ppsc").Enabled = false;
                            oForm.Items.Item("cbo_epr").Enabled = false;
                            oForm.Items.Item("cbo_rrprov").Enabled = false;
                            oForm.Items.Item("txt_frhrr").Enabled = false;
                            oForm.Items.Item("txt_frarr").Enabled = false;
                            oForm.Items.Item("txt_nrrr").Enabled = false;
                            oForm.Items.Item("txt_frearr").Enabled = false;
                            oForm.Items.Item("cbo_rra").Enabled = false;
                            oForm.Items.Item("txt_rracog").Enabled = false;
                            oForm.Items.Item("txt_feqdrr").Enabled = false;
                            oForm.Items.Item("txt_fpm").Enabled = false;
                            oForm.Items.Item("txt_nosrcg").Enabled = false;
                            oForm.Items.Item("txt_fosrcg").Enabled = false;
                            oForm.Items.Item("lbl_inccpR").Enabled = false;
                            oForm.Items.Item("txt_inccpR").Enabled = false;
                            oForm.Items.Item("lbl_fnpR").Enabled = false;
                            oForm.Items.Item("txt_fnpR").Enabled = false;
                            oForm.Items.Item("lbl_fedr").Enabled = false;
                            oForm.Items.Item("txt_fedr").Enabled = false;
                            oForm.Items.Item("mtx_action").Enabled = false;
                        }
                        else
                        {
                            oForm.Items.Item("f_General").Click();
                            oForm.Items.Item("txt_NMulta").Enabled = false;
                            oForm.Items.Item("txt_CDate").Enabled = false;
                            oForm.Items.Item("cbo_Status").Enabled = true;
                            oForm.Items.Item("txt_adminC").Enabled = true;
                            oForm.Items.Item("txt_fvc").Enabled = true;
                            oForm.Items.Item("txt_Prov").Enabled = false;
                            oForm.Items.Item("txt_Rut").Enabled = false;
                            oForm.Items.Item("txt_NProv").Enabled = false;
                            oForm.Items.Item("txt_AG").Enabled = false;
                            oForm.Items.Item("txt_agidp").Enabled = false;
                            oForm.Items.Item("txt_agral").Enabled = false;
                            oForm.Items.Item("txt_OC").Enabled = false;
                            oForm.Items.Item("txt_ocidp").Enabled = false;
                            oForm.Items.Item("txt_motive").Enabled = true;
                            oForm.Items.Item("cbo_tipoM").Enabled = true;
                            oForm.Items.Item("txt_dateR").Enabled = true;
                            oForm.Items.Item("txt_ValorM").Enabled = true;
                            oForm.Items.Item("txt_valorR").Enabled = true;
                            oForm.Items.Item("cbo_GarVen").Enabled = true;
                            oForm.Items.Item("txt_dcGar").Enabled = true;
                            oForm.Items.Item("txt_fvbg").Enabled = true;
                            oForm.Items.Item("txt_nrcg").Enabled = true;
                            oForm.Items.Item("txt_frcg").Enabled = true;
                            oForm.Items.Item("txt_novg").Enabled = true;
                            oForm.Items.Item("txt_fodcg").Enabled = true;
                            oForm.Items.Item("txt_nim").Enabled = true;
                            oForm.Items.Item("txt_fim").Enabled = true;
                            oForm.Items.Item("txt_fca").Enabled = true;
                            oForm.Items.Item("txt_feqdn").Enabled = true;
                            oForm.Items.Item("txt_idnccp").Enabled = true;
                            oForm.Items.Item("txt_fnpi").Enabled = true;
                            oForm.Items.Item("cbo_desPro").Enabled = true;
                            oForm.Items.Item("txt_fdprov").Enabled = true;
                            oForm.Items.Item("txt_nosra").Enabled = true;
                            oForm.Items.Item("txt_fosra").Enabled = true;
                            oForm.Items.Item("txt_nres").Enabled = true;
                            oForm.Items.Item("txt_fres").Enabled = true;
                            oForm.Items.Item("cbo_desc").Enabled = true;
                            oForm.Items.Item("txt_feqdd").Enabled = true;
                            oForm.Items.Item("txt_inccpr").Enabled = true;
                            oForm.Items.Item("txt_fnpr").Enabled = true;
                            oForm.Items.Item("txt_ppsc").Enabled = true;
                            oForm.Items.Item("cbo_epr").Enabled = true;
                            oForm.Items.Item("cbo_rrprov").Enabled = true;
                            oForm.Items.Item("txt_frhrr").Enabled = true;
                            oForm.Items.Item("txt_frarr").Enabled = true;
                            oForm.Items.Item("txt_nrrr").Enabled = true;
                            oForm.Items.Item("txt_frearr").Enabled = true;
                            oForm.Items.Item("cbo_rra").Enabled = true;
                            oForm.Items.Item("txt_rracog").Enabled = true;
                            oForm.Items.Item("txt_feqdrr").Enabled = true;
                            oForm.Items.Item("txt_fpm").Enabled = true;
                            oForm.Items.Item("txt_nosrcg").Enabled = true;
                            oForm.Items.Item("txt_fosrcg").Enabled = true;
                            oForm.Items.Item("lbl_inccpR").Enabled = true;
                            oForm.Items.Item("txt_inccpR").Enabled = true;
                            oForm.Items.Item("lbl_fnpR").Enabled = true;
                            oForm.Items.Item("txt_fnpR").Enabled = true;
                            oForm.Items.Item("lbl_fedr").Enabled = true;
                            oForm.Items.Item("txt_fedr").Enabled = true;
                            oForm.Items.Item("mtx_action").Enabled = true;

                        }
                        #endregion
                        break;
                }
            }
            catch(Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > ManageMenuAction(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);

            }
            finally
            {
                oForm.Freeze(false);
            }
        }

        private void LoadComboBoxes()
        {
            SAPbouiCOM.DBDataSource oDBS = null;
            SAPbobsCOM.Recordset oRS = null;

            try
            {
                #region cbo_desc
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_DESCARGO");
                if (oDBS.Size > 0)
                {
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.cbo_desc.ValidValues.Add(oDBS.GetValue("Code", i).Trim(), oDBS.GetValue("Name", i).Trim());
                    }
                }
                oDBS = null;
                #endregion

                #region mtx_action.action
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_DEFACCION");
                if (oDBS.Size > 0)
                {
                    oRS = (SAPbobsCOM.Recordset)((SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany()).GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                    oRS.DoQuery("SELECT * FROM \"@ISC_MULTA_DEFACCION\" ORDER BY \"U_Orden\" ASC");
                    while (!oRS.EoF)
                    {
                        this.mtx_action.Columns.Item("Action").ValidValues.Add(oRS.Fields.Item("Code").Value.ToString().Trim(), oRS.Fields.Item("Name").Value.ToString().Trim());
                        oRS.MoveNext();

                    }
                    /*
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.mtx_action.Columns.Item("Action").ValidValues.Add(oDBS.GetValue("Code", i).Trim(), oDBS.GetValue("Name", i).Trim());
                    }
                     */
                }
                oDBS = null;
                #endregion

                #region cbo_tipoM
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("OCRN");
                if (oDBS.Size > 0)
                {
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.cbo_tipoM.ValidValues.Add(oDBS.GetValue("CurrCode", i).Trim(), oDBS.GetValue("CurrName", i).Trim());
                    }
                    this.cbo_tipoM.Select(this.cbo_tipoM.ValidValues.Item(0).Value);
                }
                oDBS = null;
                #endregion

                #region Cbo_Status
                oDBS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_STATUS");
                if (oDBS.Size > 0)
                {
                    for (int i = 0; i < oDBS.Size; i++)
                    {
                        this.cbo_Status.ValidValues.Add(oDBS.GetValue("Code", i).Trim(), oDBS.GetValue("Name", i).Trim());
                    }
                    this.cbo_Status.Select(this.cbo_Status.ValidValues.Item(0).Value);
                }
                oDBS = null;
                #endregion
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > LoadComboBoxes(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

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

                #region clf_OOAT
                oCLF = null;
                oCLF = this.UIAPIRawForm.ChooseFromLists.Item("clf_OOAT");
                oCons = oCLF.GetConditions();
                oCon = oCons.Add();
                oCon.Alias = "BpCode";
                oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCon.CondVal = this.txt_Prov.Value;
                oCon.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;

                oCon = oCons.Add();
                oCon.Alias = "Status";
                oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCon.CondVal = "A";
                oCLF.SetConditions(oCons);
                #endregion


            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > InitializeCLFs(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private void LoadItemMatrix()
        {
            SAPbouiCOM.DBDataSource oDBDS = null;
            SAPbouiCOM.Conditions oConds = null;
            SAPbouiCOM.Condition oCond = null;
            SAPbouiCOM.DBDataSource oMatrixDBDS = null;
            try
            {
                this.UIAPIRawForm.Freeze(true);
                oDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("POR1");
                oConds = new SAPbouiCOM.Conditions();
                oCond = oConds.Add();
                oCond.Alias = "DocEntry";
                oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCond.CondVal = this.txt_OCDE.Value;
                oDBDS.Query(oConds);
                if(oDBDS.Size > 0)
                {
                    oMatrixDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_ITEM");
                    oMatrixDBDS.Clear();
                    for(int i = 0; i< oDBDS.Size; i++)
                    {
                        oMatrixDBDS.InsertRecord(i);
                        oMatrixDBDS.SetValue("U_VisLineNum", i, (i+1).ToString());
                        oMatrixDBDS.SetValue("U_ItemCode", i, oDBDS.GetValue("ItemCode", i));
                        oMatrixDBDS.SetValue("U_itemDescription", i, oDBDS.GetValue("Dscription", i));
                        oMatrixDBDS.SetValue("U_LineNume", i, oDBDS.GetValue("LineNum", i));
                        oMatrixDBDS.SetValue("U_Quantity", i, oDBDS.GetValue("Quantity", i));
                        oMatrixDBDS.SetValue("U_Price", i, oDBDS.GetValue("Price", i));
                        oMatrixDBDS.SetValue("U_LineTotal", i, oDBDS.GetValue("LineTotal", i));
                        this.mtx_Items.LoadFromDataSource();
                    }
                    this.mtx_Items.LoadFromDataSource();
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > LoadItemMatrix(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                this.UIAPIRawForm.Freeze(false);
            }
        }

        private void ManageActionMatix()
        {
            SAPbouiCOM.DBDataSource oMatrixDBDS = null;
            try 
            {
                oMatrixDBDS = this.UIAPIRawForm.DataSources.DBDataSources.Item("@ISC_MULTA_ACCION");
                this.UIAPIRawForm.Freeze(true);
                for (int i = 1; i <= this.mtx_action.RowCount; i++)
                {
                    ((SAPbouiCOM.EditText)this.mtx_action.Columns.Item("#").Cells.Item(i).Specific).Value = i.ToString();
                    if (!string.IsNullOrEmpty(oMatrixDBDS.GetValue("U_Action", i - 1).ToString().Trim()))
                        this.mtx_action.CommonSetting.SetCellEditable(i, 4, false);
                    else
                        this.mtx_action.CommonSetting.SetCellEditable(i, 4, true);

                }
                this.UIAPIRawForm.DataSources.UserDataSources.Item("#").Value = "";
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Forms.Multa.cs > ManageActionMatix(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
            finally
            {
                this.UIAPIRawForm.Freeze(false);
            }
        }
        #endregion
    }
}
