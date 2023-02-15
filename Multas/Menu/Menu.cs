using System;
using System.Collections.Generic;
using System.Text;
using SAPbouiCOM.Framework;
using System.Xml.Linq;
using System.Linq;

namespace Multas.Menu
{
    class Menu
    {

        #region Events
        public void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                switch(pVal.BeforeAction)
                {
                    case true:
                        switch(pVal.MenuUID)
                        {
                            case "Multas.Estatus":
                                Application.SBO_Application.Menus.Item(GetFormMenuId("ISC_MULTA_STATUS")).Activate();
                                GetFormMenuId("");
                                break;
                            case "Multas.Acciones":
                                Application.SBO_Application.Menus.Item(GetFormMenuId("ISC_MULTA_DEFACCION")).Activate();
                                GetFormMenuId("");
                                break;
                            case "Multas.Descargos":
                                Application.SBO_Application.Menus.Item(GetFormMenuId("ISC_MULTA_DESCARGO")).Activate();
                                GetFormMenuId("");
                                break;
                            case "Multas.Lista":
                                try
                                {
                                    Application.SBO_Application.Forms.GetForm("Multas.Forms.MultaListado", 0).Select();
                                }
                                catch
                                {
                                    Forms.MultaListado oFrmMultaListado = new Forms.MultaListado();
                                    oFrmMultaListado.Show();
                                }
                                break;
                            case "Multas.Multa":
                                try
                                {
                                    Application.SBO_Application.Forms.GetForm("Multas.Forms.Multa", 0).Select();
                                }
                                catch
                                {
                                    Application.SBO_Application.StatusBar.SetText("Cargando formulario de Multas...", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                                    Forms.Multa oFrmMulta = new Forms.Multa();
                                    oFrmMulta.Show();
                                    Application.SBO_Application.StatusBar.SetText("C", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_None);

                                }
                                break;
                            case "1281": //find
                            case "1282": //New
                                switch(Application.SBO_Application.Forms.ActiveForm.TypeEx)
                                {
                                    case "Multas.Forms.Multa":
                                        Forms.Multa.ManageMenuAction(pVal.MenuUID);
                                        break;
                                }
                                break;
                            case "1292":
                            case "1293":
                            case "1286":
                                switch(Application.SBO_Application.Forms.ActiveForm.TypeEx)
                                {
                                    case "Multas.Forms.Multa":
                                        Forms.Multa.rightClickMenuId = pVal.MenuUID;
                                        break;
                                }
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Menu.cs > SBO_Application_MenuEvent(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }
        #endregion

        #region Methods
        public void AddMenuItems()
        {
            SAPbouiCOM.Menus oMenus = null;
            SAPbouiCOM.MenuItem oMenuItem = null;

            oMenus = Application.SBO_Application.Menus;

            SAPbouiCOM.MenuCreationParams oCreationPackage = null;
            oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));

            try
            {
                oMenuItem = Application.SBO_Application.Menus.Item("2304"); // Purchases'
                if (!oMenuItem.SubMenus.Exists("GestionMultas"))
                {
                    #region Main Menu
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
                    oCreationPackage.UniqueID = "GestionMultas";
                    oCreationPackage.String = "Gestión de Multas";
                    oCreationPackage.Enabled = true;
                    oCreationPackage.Position = -1;
                    oMenus = oMenuItem.SubMenus;
                    oMenus.AddEx(oCreationPackage);
                    #endregion

                    #region Sub-Menu
                    // Get the menu collection of the newly added pop-up item
                    oMenuItem = Application.SBO_Application.Menus.Item("GestionMultas");
                    oMenus = oMenuItem.SubMenus;

                    //Sub menu Multas Estatus
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "Multas.Estatus";
                    oCreationPackage.String = "Multas Estatus";
                    oMenus.AddEx(oCreationPackage);

                    //Sub menu Multas Acciones
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "Multas.Acciones";
                    oCreationPackage.String = "Multas Acciones";
                    oMenus.AddEx(oCreationPackage);

                    //Sub menu Multas Descargos
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "Multas.Descargos";
                    oCreationPackage.String = "Multas Descargos";
                    oMenus.AddEx(oCreationPackage);

                    //Sub menu Multas Listado
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "Multas.Lista";
                    oCreationPackage.String = "Listado de Multas";
                    oMenus.AddEx(oCreationPackage);

                    //Sub menu Multa
                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    oCreationPackage.UniqueID = "Multas.Multa";
                    oCreationPackage.String = "Multa";
                    oMenus.AddEx(oCreationPackage);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Menu.cs > AddMenuItems(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
            }
        }

        private string GetFormMenuId(string nombreForm)
        {
            XElement oMenus = null;
            IEnumerable<XElement> oMenuItems = null;
            string menuId = "";
            try
            {
                oMenus = XElement.Parse(Application.SBO_Application.Menus.Item("51200").SubMenus.GetAsXML());
                oMenuItems= oMenus.Descendants("Menu").Where(menu => ((string)menu.Attribute("String")).Contains(nombreForm));
                menuId = oMenuItems.ToList().FirstOrDefault().Attribute("UniqueID").Value;
            }
            catch (Exception ex)
            {
                Application.SBO_Application.StatusBar.SetText("Error: Multas.Menu.cs > GetFormMenuId(): " + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);

            }
            return menuId;
        }
        #endregion
    }
}
